using MySql.Data.MySqlClient;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerCreditPaymentUserControl : UserControl
    {
        public ManagerCreditPaymentUserControl()
        {
            InitializeComponent();
            InitializeCustomerNameCombobox();
        }

        private void InitializeCustomerNameCombobox()
        {
            BindingList<string> nameList = new BindingList<string>();
            MySqlConnection conn = DBConnector.Connector();
            conn.Open();

            string query = "SELECT name FROM customers;";
            var cmd = new MySqlCommand(query, conn);

            var reader = cmd.ExecuteReader();
            nameList.Add("");
            while (reader.Read())
            {
                nameList.Add(reader.GetString(0));
            }

            nameCombox.DataSource = nameList;

            conn.Close();
        }

        private void nameCombox_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();


            conn.Open();
            // Fill out the phone number
            string query = "SELECT phone_number " +
                "FROM customers " +
                "WHERE name = '" + nameCombox.SelectedValue.ToString() + "'";
            var cmd = new MySqlCommand(query, conn);

            var reader = cmd.ExecuteReader();

            // check if there is already a customer named as the input
            // load the number
            BindingList<string> phoneList = new BindingList<string>();
            if (!reader.HasRows)
            {
                phoneCombox.DataSource = null;
                conn.Close();
                return;
            }

            while (reader.Read())
            {
                phoneList.Add(reader.GetString(0));
            }

            phoneCombox.DataSource = phoneList;

            conn.Close();


            // fill the credit amount textbox
            // it is where the total amount of credit that the user has
            conn.Open();
            string credtiAmountQuery = "SELECT customers.name, sum(amount_due) FROM sales " +
                "JOIN customers ON sales.customer_id = customers.id " +
                "WHERE customers.name = @name " +
                "group by customer_id;";
            var creditAmountCmd = new MySqlCommand(credtiAmountQuery, conn);
            creditAmountCmd.Parameters.AddWithValue("@name", nameCombox.SelectedValue.ToString());
            var creditAmountReader = creditAmountCmd.ExecuteReader();
            double totalCreditAmount = 0;
            if (!creditAmountReader.HasRows)
            {
                MessageBox.Show("Customer is not found");
                conn.Close();
                return;
            }
            while (creditAmountReader.Read())
            {
                totalCreditAmount += creditAmountReader.GetDouble(1);
            }
            // set the totalCreditAmount to the credit amount textbox
            this.creditAmountTextBox.Text = totalCreditAmount.ToString();

            conn.Close();



        }
    }
}
