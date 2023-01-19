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
            AutocompleteForCustomerName();
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

        private void AutocompleteForCustomerName()
        {
            MySqlConnection conn = DBConnector.Connector();
            conn.Open();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            // add the product names to the collection
            string query = "SELECT name FROM customers;";
            var cmd = new MySqlCommand(query, conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                autoComplete.Add(reader.GetString(0));
            }

            // set the autoComplete object to the combobox
            nameCombox.AutoCompleteCustomSource = autoComplete;
            nameCombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nameCombox.AutoCompleteSource = AutoCompleteSource.CustomSource;

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
                //MessageBox.Show("Customer is not found");
                this.creditAmountTextBox.Text = "P 0";
                conn.Close();
                return;
            }
            while (creditAmountReader.Read())
            {
                totalCreditAmount += creditAmountReader.GetDouble(1);
            }
            // set the totalCreditAmount to the credit amount textbox
            this.creditAmountTextBox.Text = "P " + totalCreditAmount.ToString();

            conn.Close();



        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // message box employee deletion
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to cancel the credit payment?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the form's inputs will not be cleared
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            ClearForms();
        }

        private void ClearForms()
        {
            // clear all form's input
            nameCombox.ResetText();
            phoneCombox.ResetText();
            phoneCombox.DataSource = null;
            creditAmountTextBox.ResetText();
            paymentTextbox.ResetText();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // check if all the forms is fill up
            if (IsFormsFilledUp())
            {
                MessageBox.Show("Fill out all text box.");
                return;
            }

            // check of payment is more than 0
            if (double.Parse(paymentTextbox.Text.Trim()) <= 0)
            {
                MessageBox.Show("Put payment larger than P 0");
                return;
            }

            MySqlConnection conn = DBConnector.Connector();
            conn.Open();

            double remainingPayment = double.Parse(this.paymentTextbox.Text.Trim());

            // get the list of credit of the customer
            string creditListQuery = "SELECT * FROM sales " +
                "JOIN customers ON sales.customer_id = customers.id " +
                "WHERE sales.amount_due > 0 AND customers.name = @name;";
            var creditListCmd = new MySqlCommand(creditListQuery, conn);
            creditListCmd.Parameters.AddWithValue("@name", nameCombox.SelectedValue.ToString().Trim());
            var creditListReader = creditListCmd.ExecuteReader();

            if (!creditListReader.HasRows)
            {
                MessageBox.Show("The customer has no credit");
                ClearForms();
                return;
            }
            double remainingCredit = 0;

            MySqlConnection conn2 = DBConnector.Connector();
            conn2.Open();
            while (creditListReader.Read())
            {
                if (remainingPayment > 0)
                {
                    // update the amount_due in the sales table

                    string updateCreditQuery = "UPDATE sales " +
                        "JOIN customers ON sales.customer_id = customers.id " +
                        "SET sales.amount_due = @newAmountDue " +
                        "WHERE sales.id = @id; " +
                        "INSERT INTO payment (sale_id, amount, payment_type) " +
                        "VALUE (@salesID, @amount, 'Credit'); ";
                    var updateCreditCmd = new MySqlCommand(updateCreditQuery, conn2);
                    updateCreditCmd.Parameters.AddWithValue("@id", creditListReader.GetInt32("id"));
                    // 
                    if (remainingPayment >= creditListReader.GetDouble("amount_due"))
                    {
                        updateCreditCmd.Parameters.AddWithValue("@newAmountDue", 0);
                        remainingPayment -= creditListReader.GetDouble("amount_due");
                        updateCreditCmd.Parameters.AddWithValue("@salesID", creditListReader.GetString("id"));
                        updateCreditCmd.Parameters.AddWithValue("@amount", creditListReader.GetDouble("amount_due"));
                    }
                    else
                    {
                        updateCreditCmd.Parameters.AddWithValue("@newAmountDue",
                            creditListReader.GetDouble("amount_due") - remainingPayment);
                        updateCreditCmd.Parameters.AddWithValue("@salesID", creditListReader.GetString("id"));
                        updateCreditCmd.Parameters.AddWithValue("@amount", remainingPayment);
                        remainingPayment = 0;
                    }
                    var result = updateCreditCmd.ExecuteNonQuery();
                    continue;
                }
                remainingCredit += creditListReader.GetDouble("amount_due");

            }
            conn2.Close();

            MessageBox.Show("Successfully save the credit payment\n" +
                "Remaining credit: P" + remainingCredit);
            ClearForms();
        }

        private bool IsFormsFilledUp()
        {
            return string.IsNullOrEmpty(nameCombox.Text.Trim()) ||
                string.IsNullOrEmpty(phoneCombox.Text.Trim()) ||
                string.IsNullOrEmpty(paymentTextbox.Text.Trim());
        }

        private void paymentTextbox_Leave(object sender, EventArgs e)
        {
            decimal payment;
            if (!decimal.TryParse(paymentTextbox.Text, out payment) || payment < 0)
            {
                MessageBox.Show("Invalid Payment Value. Please enter a valid positive amount.");
                paymentTextbox.Focus();
            }
        }

        private void ManagerCreditPaymentUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitializeCustomerNameCombobox();
                AutocompleteForCustomerName();
            }
        }
    }
}
