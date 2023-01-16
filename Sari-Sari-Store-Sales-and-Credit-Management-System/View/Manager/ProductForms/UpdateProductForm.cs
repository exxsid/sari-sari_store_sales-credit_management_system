using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using System.Windows.Forms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using MySql.Data.MySqlClient;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms
{
    public partial class UpdateProductForm : Form
    {
        private Product product;
        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            // set the value to the textbox
            this.productNameTextbox.Text = this.product.GetName();
            this.quantityTextbox.Text = this.product.GetQuantity().ToString();
            this.priceTextbox.Text = this.product.GetRetailPrice().ToString();
            this.wholesalePriceTextbox.Text = this.product.GetWholesalePrice().ToString();
        }


        private void saveButton_Click(object sender, System.EventArgs e)
        {
            // check all the textbox
            // to ensure non of the textbox is empty
            if (CheckTextbox())
            {
                MessageBox.Show("Fill out all textbox");
                return;
            }

            if (this.typeCombobox.Text == "Purchase")
            {
                PurchaseQuery();
                return;
            }
            // when destroyed is selected
            DestroyedQuery();
        }

        private bool CheckTextbox()
        {
            return string.IsNullOrEmpty(this.productNameTextbox.Text) ||
                string.IsNullOrEmpty(this.quantityTextbox.Text) ||
                string.IsNullOrEmpty(this.priceTextbox.Text) ||
                string.IsNullOrEmpty(this.wholesalePriceTextbox.Text) ||
                string.IsNullOrEmpty(this.typeCombobox.Text);
        }

        private void PurchaseQuery()
        {
            MySqlConnection connection = DBConnector.Connector();
            

            int currentQuantity = GetCurrentProductQuantity();
            int newQuantity = currentQuantity + int.Parse( this.quantityTextbox.Text);

            string query = "UPDATE products " +
                "SET name = @name, " +
                "quantity = @newQuantity, " +
                "retail_price = @retPrice " +
                "WHERE id = @prodId;";
            // TODO: open() connection
            connection.Open();
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", this.product.GetName());
            cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
            cmd.Parameters.AddWithValue("@retPrice", this.product.GetRetailPrice());
            cmd.Parameters.AddWithValue("@prodId", this.product.GetId());
            
            var result = cmd.ExecuteNonQuery();
            if (result <= 0)
            {
                connection.Close();
                MessageBox.Show("Unable to update the prodct");
                return;
            }

            // update the purchase table
            string purchaseQuery = "INSERT INTO purchase (product_id, wholesale_price, quantity) " +
                "VALUE (@prodId, @wholesalePrice, @quantity);";
            var purchaseCmd = new MySqlCommand(purchaseQuery, connection);
            purchaseCmd.Parameters.AddWithValue("@prodId", this.product.GetId());
            purchaseCmd.Parameters.AddWithValue("@wholesalePrice", this.product.GetWholesalePrice());
            purchaseCmd.Parameters.AddWithValue("@quantity", this.product.GetQuantity());

            result = purchaseCmd.ExecuteNonQuery();
            if (result <= 0)
            {
                connection.Close();
                MessageBox.Show("Unable to update the product");
                return;
            }

            MessageBox.Show("Product purchase succesfuly Updated", "Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private int GetCurrentProductQuantity()
        {
            MySqlConnection connection = DBConnector.Connector();
            connection.Open();
            // get the current quantity of products
            string currentQttyQuery = "SELECT quantity FROM products WHERE id = @id;";
            var cmd = new MySqlCommand(currentQttyQuery, connection);
            cmd.Parameters.AddWithValue("@id", product.GetId());

            var reader = cmd.ExecuteReader();
            reader.Read();
            int curr = reader.GetInt32("quantity");
            connection.Close();
            return curr;

        }

        private void DestroyedQuery()
        {
            MySqlConnection connection = DBConnector.Connector();


            int currentQuantity = GetCurrentProductQuantity();
            int newQuantity = currentQuantity - this.product.GetQuantity();

            string query = "UPDATE products " +
                "SET name = @name, " +
                "quantity = @newQuantity, " +
                "retail_price = @retPrice " +
                "WHERE id = @prodId;";
            // TODO: open() connection
            connection.Open();
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", this.product.GetName());
            cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
            cmd.Parameters.AddWithValue("@retPrice", this.product.GetRetailPrice());
            cmd.Parameters.AddWithValue("@prodId", this.product.GetId());

            var result = cmd.ExecuteNonQuery();
            if (result <= 0)
            {
                connection.Close();
                MessageBox.Show("Unable to update the prodct");
                return;
            }

            // update the purchase table
            string purchaseQuery = "INSERT INTO destroyed_product (product_id, quantity) " +
                "VALUE (@prodId, @quantity);";
            var destroyedCmd = new MySqlCommand(purchaseQuery, connection);
            destroyedCmd.Parameters.AddWithValue("@prodId", this.product.GetId());
            destroyedCmd.Parameters.AddWithValue("@quantity", this.product.GetQuantity());

            result = destroyedCmd.ExecuteNonQuery();
            if (result <= 0)
            {
                connection.Close();
                MessageBox.Show("Unable to update the product");
                return;
            }

            MessageBox.Show("Product purchase succesfuly Updated", "Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

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
    }
}
