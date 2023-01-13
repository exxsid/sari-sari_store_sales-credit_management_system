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
            // TODO: populate datagrid
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            NewProductForm addProd = new NewProductForm();
            addProd.Show();

            //TODO: refresh the datagrid
            
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = productsDataGrid.SelectedRows[0];

                // create a Produc object
                // store values from the selected row
                // TODO: check again the cell name
                Product prod = new Product();
                prod.Id = int.Parse(selectedRow.Cells["id"].Value.ToString());
                prod.Name = selectedRow.Cells["name"].Value.ToString();
                prod.Quantity = int.Parse(selectedRow.Cells["quantity"].Value.ToString());
                prod.Price = double.Parse(selectedRow.Cells["price"].Value.ToString());
                prod.BoughtPrice = double.Parse(selectedRow.Cells["price"].Value.ToString());

                UpdateProductForm update = new UpdateProductForm();
                update.Product = prod;

                update.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a row", "Tip",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
