using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerProductsUserControl : UserControl
    {

        public ManagerProductsUserControl()
        {
            InitializeComponent();
            // re/load the the datagrid for products
            ProductDAO productDao = new ProductDAO();

            productsDataGrid.DataSource = productDao.GetProducts();
            SetTableHeader();
        }

        private void ManagerProductsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            NewProductForm addProd = new NewProductForm();
            addProd.Show();



        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = productsDataGrid.SelectedRows[0];

                // create a Produc object
                // store values from the selected row
                Product prod = new Product(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    int.Parse(selectedRow.Cells[2].Value.ToString()),
                    double.Parse(selectedRow.Cells[3].Value.ToString()),
                    double.Parse(selectedRow.Cells[4].Value.ToString()),
                    selectedRow.Cells[5].Value.ToString()
                    );

                UpdateProductForm update = new UpdateProductForm(prod);

                update.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a row", "Tip",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            // re/load the the datagrid for products
            ProductDAO productDao = new ProductDAO();

            productsDataGrid.DataSource = productDao.GetProducts();
            SetTableHeader();
        }

        private void SetTableHeader()
        {
            productsDataGrid.Columns[0].HeaderText = "ID";
            productsDataGrid.Columns[1].HeaderText = "Name";
            productsDataGrid.Columns[2].HeaderText = "Quantity";
            productsDataGrid.Columns[3].HeaderText = "Retail Price";
            productsDataGrid.Columns[4].HeaderText = "Wholesale Price";
            productsDataGrid.Columns[5].HeaderText = "Status";
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            // message box changing status of the product
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to change the product's status?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            int prodIdSelected = int.Parse(productsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            MySqlConnection conn = DBConnector.Connector();

            string currStatusQuery = productsDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            conn.Open();
            string query = "UPDATE products " +
                "SET status = @status " +
                "WHERE id = " + prodIdSelected;

            var cmd = new MySqlCommand(query, conn);
            if (currStatusQuery == "Available")
            {
                cmd.Parameters.AddWithValue("@status", "Not Available");
            }
            else
            {
                cmd.Parameters.AddWithValue("@status", "Available");
            }

            var result = cmd.ExecuteNonQuery();
            if (result == -1)
            {
                conn.Close();
                MessageBox.Show("Unable to update the product");
                return;
            }
            conn.Close();

            MessageBox.Show("Product status succesfuly Updated", "Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();

            conn.Open();
            if (string.IsNullOrEmpty(searchBar.Text.Trim()))
            {
                MessageBox.Show("Fill out the search bar.");
                conn.Close();
                return;
            }

            string query = "SELECT * " +
                "FROM products " +
                "WHERE name LIKE '%" + searchBar.Text.Trim() + "%';";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            productsDataGrid.DataSource = table;
            conn.Close();
            SetTableHeader();
        }

        private void ManagerProductsUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ProductDAO productDao = new ProductDAO();

                productsDataGrid.DataSource = productDao.GetProducts();
                SetTableHeader();
            }
        }
    }
}
