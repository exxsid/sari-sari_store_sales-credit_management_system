using MySql.Data.MySqlClient;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        public Product Product { set { this.Product = value; } }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to exit?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            this.Close();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            // TODO: implement saving new product
            MySqlConnection connection = DBConnector.Connector();
            // open the connection
            connection.Open();
            
            // check if the product is in the database already
            if (IsInDatabase(this.productNameTextbox.Text.Trim()))
            {
                connection.Close();
                MessageBox.Show("Product already exist.\nUse the update option instead.");
                return;
            }

            // insert into the products table
            string query = "INSERT INTO products (name, retail_price, quantity) " +
                "VALUE (@name, @retPrice, @quantity);";
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", this.productNameTextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@retPrice", this.priceTextbox.Text.Trim());
            cmd.Parameters.AddWithValue("@quantity", this.quantityTextbox.Text.Trim());

            var result = cmd.ExecuteNonQuery();
            if (result == -1)
            {
                connection.Close();
                MessageBox.Show("Unable to add the new product");
                return;
            }
            // insert value in purchase table
            // get the product_id of the newly added product
            string prodIdQuery = "SELECT * FROM products WHERE name = " + this.productNameTextbox.Text.Trim();
            var prodIdCmd = new MySqlCommand(prodIdQuery, connection);
            var reader = prodIdCmd.ExecuteReader();
            reader.Read();
            int prodId = reader.GetInt32("id");

            string purchaseQuery = "INSERT INTO products (name, retail_price, quantity) " +
                "VALUE (@product_id, @wholePrice, @quantity);";
            var purchaseCmd = new MySqlCommand(query, connection);
            purchaseCmd.Parameters.AddWithValue("@name", prodId);
            purchaseCmd.Parameters.AddWithValue("@retPrice", this.wholesalePriceLabel.Text.Trim());
            purchaseCmd.Parameters.AddWithValue("@quantity", this.quantityTextbox.Text.Trim());
            result = cmd.ExecuteNonQuery();

            // when the insertion of new product is successful
            connection.Close();

            MessageBox.Show("Employee succesfuly Updated", "Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool IsInDatabase(string prodName)
        {
            // TODO: implement saving new product
            MySqlConnection connection = DBConnector.Connector();
            // open the connection
            connection.Open();

            string query = "SELECT * FROM products WHERE name = " + prodName;
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            return reader.HasRows;
        }
    }
}
