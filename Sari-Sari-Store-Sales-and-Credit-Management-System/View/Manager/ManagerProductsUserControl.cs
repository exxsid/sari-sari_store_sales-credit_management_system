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
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerProductsUserControl : UserControl
    {

        public ManagerProductsUserControl()
        {
            InitializeComponent();
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
                    double.Parse(selectedRow.Cells[4].Value.ToString())
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

        private void searchButton_Click(object sender, EventArgs e)
        {

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
        }
    }
}
