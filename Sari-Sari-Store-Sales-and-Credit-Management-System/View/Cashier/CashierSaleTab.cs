using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier
{
    public partial class CashierSaleTab : UserControl
    {
        string connect = "server=localhost;port=3306;user=root;password='';database=sari-sari_store";
        public CashierSaleTab()
        {
            InitializeComponent();
            productCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            productCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void CashierSaleTab_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();

            string query = "SELECT * FROM products";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            productCombobox.DataSource = dt;
            productCombobox.DisplayMember = "product_name";
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string product = productCombobox.Text;
            double quantity = Convert.ToDouble(quantityTextbox.Text);
            double unitprice = Convert.ToDouble(unitPriceTextBox.Text);

            double total = quantity * unitprice;

            totalPriceTextbox.Text = total.ToString();
        }

        private void productCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void productCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = productCombobox.Text;
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();

            string query = "SELECT price FROM products WHERE product_name = @item";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@item", item);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                unitPriceTextBox.Text = reader["price"].ToString();
            }
        }
    }
}
