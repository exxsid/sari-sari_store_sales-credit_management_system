using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerSaleUserControl : UserControl
    {
        private string _customerName;
        private string _customerPhone;
        public ManagerSaleUserControl()
        {
            InitializeComponent();
            InitializeAutoCompleteProduct();
            // InitializeProductComboboxItems();
            InitializeCustomerComboboxItems();
        }

        private void InitializeCustomerComboboxItems()
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

            customerNameCombobox.DataSource = nameList;

            conn.Close();
        }

        private void InitializeProductComboboxItems()
        {
            ProductDAO productDao = new ProductDAO();
            productCombobox.DataSource = productDao.GetAvailableProducts();
            productCombobox.DisplayMember = "name";
        }

        private void InitializeAutoCompleteProduct()
        {
            productCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            productCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            customerNameCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            customerNameCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void quantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            // check the product and quantity if it is not null or empty
            if (!(string.IsNullOrEmpty(this.unitPriceTextBox.Text.Trim())) &&
                !(string.IsNullOrEmpty(this.quantityTextbox.Text.Trim())))
            {

                // check if the product in combobox is in the database
                if (!IsInDatabase(this.productCombobox.Text.Trim()))
                {
                    MessageBox.Show("Product is not included");
                    return;
                }

                double quantity = Convert.ToDouble(quantityTextbox.Text);
                double unitprice = Convert.ToDouble(unitPriceTextBox.Text);
                double total = quantity * unitprice;
                bool itemExists = false;
                int existingRowIndex = -1;

                for (int i = 0; i < saleDataGridView.Rows.Count; i++)
                {
                    if (saleDataGridView.Rows[i].Cells["Column1"].Value.ToString() == this.productCombobox.Text)
                    {
                        itemExists = true;
                        existingRowIndex = i;
                        break;
                    }
                }

                if (itemExists)
                {
                    double existingQuantity = Convert.ToDouble(saleDataGridView.Rows[existingRowIndex].Cells["Column2"].Value);
                    double existingUnitPrice = Convert.ToDouble(saleDataGridView.Rows[existingRowIndex].Cells["Column3"].Value);

                    double newTotal = (existingQuantity + quantity) * existingUnitPrice;
                    saleDataGridView.Rows[existingRowIndex].Cells["Column2"].Value = existingQuantity + quantity;
                    saleDataGridView.Rows[existingRowIndex].Cells["Column4"].Value = newTotal;
                }
                else
                {
                    saleDataGridView.Rows.Add(this.productCombobox.Text, quantity, unitprice, total);
                }

                /*
                // add the product and quantity to the datagridview
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(saleDataGridView);
                row.Cells[0].Value = this.productCombobox.Text.Trim();
                row.Cells[1].Value = this.quantityTextbox.Text.Trim();
                row.Cells[2].Value = this.unitPriceTextBox.Text.Trim();
                // multiply the quantity to the unit price
                int quantity = int.Parse(this.quantityTextbox.Text.Trim());
                double totalUnitPrice = quantity * double.Parse(this.unitPriceTextBox.Text.Trim());
                row.Cells[3].Value = totalUnitPrice;
                saleDataGridView.Rows.Add(row); */

                // clear the text box
                this.quantityTextbox.Text = "1";
                this.unitPriceTextBox.Clear();

                // set the total price
                SetTotalPrice();
                // set the total quantity
                SetTotalQuantity();
            }
            else
            {
                MessageBox.Show("Fill out product and quantity");
                return;
            }
        }

        private void SetTotalPrice()
        {
            double totalPrice = 0;
            foreach (DataGridViewRow row in saleDataGridView.Rows)
            {
                totalPrice += double.Parse(row.Cells[3].Value.ToString());
            }

            this.totalPriceTextbox.Text = totalPrice.ToString();
        }

        private void SetTotalQuantity()
        {
            int totalQuantity = 0;
            foreach (DataGridViewRow row in saleDataGridView.Rows)
            {
                totalQuantity += int.Parse(row.Cells[1].Value.ToString());
            }

            this.totalQuantityTextbox.Text = totalQuantity.ToString();
        }

        private bool IsInDatabase(string prodName)
        {
            MySqlConnection connection = DBConnector.Connector();
            // open the connection
            connection.Open();

            string query = "SELECT * FROM products WHERE name = '" + prodName + "'";
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            return reader.HasRows;
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            // message box employee deletion
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to remove the product?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            if (saleDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = saleDataGridView.SelectedRows[0];
                saleDataGridView.Rows.Remove(selectedRow);
            }

            // set the total price
            SetTotalPrice();
            // set the total quantity
            SetTotalQuantity();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // message box employee deletion
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to cancel the sale?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            saleDataGridView.Rows.Clear();
            // set the total price
            SetTotalPrice();
            // set the total quantity
            SetTotalQuantity();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();

            // check if there is entered payment 
            if (!(string.IsNullOrEmpty(this.paymentTextbox.Text)))
            {
                // check if the text for customer info is not empty
                // it means it is credit

                // when the payment is lower than total amount
                // tell the user to 
                if ((double.Parse(this.paymentTextbox.Text.Trim()) <
                    double.Parse(this.totalPriceTextbox.Text)) &&
                    string.IsNullOrEmpty(this.customerNameCombobox.Text.Trim())
                    )
                {
                    MessageBox.Show("Fill out the Customer's name and phone");
                    return;
                }
                if (!string.IsNullOrEmpty(this.customerNameCombobox.Text.Trim()))
                {
                    int customerId = 0;
                    // when the customer do not have 
                    if (string.IsNullOrEmpty(this.paymentTextbox.Text.Trim()))
                    {
                        this.paymentTextbox.Text = 0.ToString();
                    }
                    // then check if the customer is already exist in the database
                    if (!CustomerIsInDatabase(this.customerNameCombobox.Text.Trim()))
                    {
                        conn.Open();
                        // add the new customer to database
                        string addCustQuery = "INSERT INTO customers (name, phone_number) " +
                            "VALUE (@name, @phoneNumber);";
                        var addCmd = new MySqlCommand(addCustQuery, conn);
                        addCmd.Parameters.AddWithValue("@name", this.customerNameCombobox.Text.Trim());
                        addCmd.Parameters.AddWithValue("@phoneNumber", this.customerPhoneCombobox.Text.Trim());

                        var result = addCmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    // get the customer's id
                    conn.Open();
                    string query = "SELECT id FROM customers WHERE name = '" +
                            this.customerNameCombobox.Text.Trim() + "'";
                    var cmd = new MySqlCommand(query, conn);

                    var reader = cmd.ExecuteReader();

                    reader.Read();

                    customerId = reader.GetInt32(0);
                    conn.Close();
                    // calculate the amount due
                    // the amount that the customer still needed to pay
                    // total price - payment
                    double amountDue = double.Parse(this.totalPriceTextbox.Text) - double.Parse(this.paymentTextbox.Text.Trim());
                    // insert the sale value to database
                    conn.Open();
                    string insertSaleQuery = "INSERT INTO sales (customer_id, amount_due, total_amount) " +
                        "VALUE (@customerId, @amountDue, @totalAmount);";
                    var insertSaleCmd = new MySqlCommand(insertSaleQuery, conn);
                    insertSaleCmd.Parameters.AddWithValue("@customerId", customerId);
                    insertSaleCmd.Parameters.AddWithValue("@amountDue", amountDue);
                    insertSaleCmd.Parameters.AddWithValue("@totalAmount", this.totalPriceTextbox.Text.Trim());

                    var insertResult = insertSaleCmd.ExecuteNonQuery();
                    conn.Close();
                    // insert into the sale_details table
                    // first get the sales id
                    conn.Open();
                    string saleIdQuery = "SELECT id FROM sales ORDER BY id DESC LIMIT 1;";
                    var saleIdCmd = new MySqlCommand(saleIdQuery, conn);
                    var saleIdReader = saleIdCmd.ExecuteReader();
                    saleIdReader.Read();
                    int salesId = saleIdReader.GetInt32(0);
                    conn.Close();
                    // get the product id for each product
                    // then insert it to sale_details table
                    foreach (DataGridViewRow row in saleDataGridView.Rows)
                    {
                        conn.Open();
                        string prodIdQuery = "SELECT * FROM products WHERE name = '" + row.Cells[0].Value.ToString() + "'";
                        var prodIdCmd = new MySqlCommand(prodIdQuery, conn);
                        var prodIdReader = prodIdCmd.ExecuteReader();
                        prodIdReader.Read();
                        int prodId = prodIdReader.GetInt32(0);
                        conn.Close();
                        // insert to the sale_details
                        conn.Open();
                        string insertSaleDetails = "INSERT INTO sale_details(sale_id, product_id, price, quantity) " +
                            "VALUE (@saleId, @productId, @price, @quantity);";
                        var insertSaleDetailsCmd = new MySqlCommand(insertSaleDetails, conn);
                        insertSaleDetailsCmd.Parameters.AddWithValue("@saleId", salesId);
                        insertSaleDetailsCmd.Parameters.AddWithValue("@productId", prodId);
                        insertSaleDetailsCmd.Parameters.AddWithValue("@price", row.Cells[2].Value.ToString());
                        insertSaleDetailsCmd.Parameters.AddWithValue("@quantity", row.Cells[1].Value.ToString());

                        var insertSaleDetailsResult = insertSaleDetailsCmd.ExecuteNonQuery();
                        conn.Close();
                        // update the quantity of each product in products table
                        conn.Open();
                        string updateProductQuantity = "UPDATE products " +
                            "SET quantity = quantity - @quantity " +
                            "WHERE id = @prodId;";
                        var updateProductQuantityCmd = new MySqlCommand(updateProductQuantity, conn);
                        updateProductQuantityCmd.Parameters.AddWithValue("@quantity", row.Cells[1].Value.ToString());
                        updateProductQuantityCmd.Parameters.AddWithValue("@prodId", prodId);
                        var updateProdQttyResult = updateProductQuantityCmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    // set to payment
                    if (double.Parse(this.paymentTextbox.Text) != 0)
                    {
                        conn.Open();
                        string paymentQuery = "INSERT INTO payment (sale_id, amount, payment_type) " +
                            "VALUE (@saleId, @amount, 'Credit')";
                        var paymentCmd = new MySqlCommand(paymentQuery, conn);
                        paymentCmd.Parameters.AddWithValue("@saleId", salesId);
                        paymentCmd.Parameters.AddWithValue("@amount", this.totalPriceTextbox.Text);

                        var paymentResult = paymentCmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    // clear all textbox
                    saleDataGridView.Rows.Clear();
                    // set the total price
                    SetTotalPrice();
                    // set the total quantity
                    SetTotalQuantity();
                    this.paymentTextbox.Text = 0.ToString();
                    MessageBox.Show("Successfully save sale\nChange: 0");
                    return;
                }


                #region cash
                // when the text for customer name is empty
                // it means it is cash
                // calculate the amount due
                // the amount that the customer still needed to pay
                // total price - payment
                double amountDue1 = double.Parse(this.totalPriceTextbox.Text) - double.Parse(this.paymentTextbox.Text.Trim());
                if (amountDue1 < 0)
                {
                    amountDue1 = 0;
                }
                // insert the sale value to database
                conn.Open();
                string insertSaleQuery1 = "INSERT INTO sales ( amount_due, total_amount) " +
                    "VALUE (@amountDue, @totalAmount);";
                var insertSaleCmd1 = new MySqlCommand(insertSaleQuery1, conn);
                insertSaleCmd1.Parameters.AddWithValue("@amountDue", amountDue1);
                insertSaleCmd1.Parameters.AddWithValue("@totalAmount", this.totalPriceTextbox.Text.Trim());

                var insertResult1 = insertSaleCmd1.ExecuteNonQuery();
                conn.Close();

                // insert into the sale_details table
                // first get the sales id
                conn.Open();
                string saleIdQuery1 = "SELECT id FROM sales ORDER BY id DESC LIMIT 1;";
                var saleIdCmd1 = new MySqlCommand(saleIdQuery1, conn);
                var saleIdReader1 = saleIdCmd1.ExecuteReader();
                saleIdReader1.Read();
                int salesId1 = saleIdReader1.GetInt32(0);
                conn.Close();
                // get the product id for each product
                // then insert it to sale_details table
                foreach (DataGridViewRow row in saleDataGridView.Rows)
                {
                    conn.Open();
                    string prodIdQuery1 = "SELECT * FROM products WHERE name = '" + row.Cells[0].Value.ToString() + "'";
                    var prodIdCmd1 = new MySqlCommand(prodIdQuery1, conn);
                    var prodIdReader1 = prodIdCmd1.ExecuteReader();
                    prodIdReader1.Read();
                    int prodId1 = prodIdReader1.GetInt32(0);
                    conn.Close();
                    // insert to the sale_details
                    conn.Open();
                    string insertSaleDetails1 = "INSERT INTO sale_details(sale_id, product_id, price, quantity) " +
                        "VALUE (@saleId, @productId, @price, @quantity);";
                    var insertSaleDetailsCmd1 = new MySqlCommand(insertSaleDetails1, conn);
                    insertSaleDetailsCmd1.Parameters.AddWithValue("@saleId", salesId1);
                    insertSaleDetailsCmd1.Parameters.AddWithValue("@productId", prodId1);
                    insertSaleDetailsCmd1.Parameters.AddWithValue("@price", row.Cells[2].Value.ToString());
                    insertSaleDetailsCmd1.Parameters.AddWithValue("@quantity", row.Cells[1].Value.ToString());

                    var insertSaleDetailsResult1 = insertSaleDetailsCmd1.ExecuteNonQuery();
                    conn.Close();
                    // update the quantity of each product in products table
                    conn.Open();
                    string updateProductQuantity = "UPDATE products " +
                        "SET quantity = quantity - @quantity " +
                        "WHERE id = @prodId;";
                    var updateProductQuantityCmd = new MySqlCommand(updateProductQuantity, conn);
                    updateProductQuantityCmd.Parameters.AddWithValue("@quantity", row.Cells[1].Value.ToString());
                    updateProductQuantityCmd.Parameters.AddWithValue("@prodId", prodId1);
                    var updateProdQttyResult = updateProductQuantityCmd.ExecuteNonQuery();
                    conn.Close();
                }

                conn.Open();
                string paymentQuery1 = "INSERT INTO payment (sale_id, amount, payment_type) " +
                    "VALUE (@saleId, @amount, 'Cash')";
                var paymentCmd1 = new MySqlCommand(paymentQuery1, conn);
                paymentCmd1.Parameters.AddWithValue("@saleId", salesId1);
                paymentCmd1.Parameters.AddWithValue("@amount", this.totalPriceTextbox.Text);

                var paymentResult1 = paymentCmd1.ExecuteNonQuery();
                conn.Close();
                // clear all textbox
                saleDataGridView.Rows.Clear();
                // set the total price
                SetTotalPrice();
                // set the total quantity
                SetTotalQuantity();
                this.paymentTextbox.Text = 0.ToString();
                double change = double.Parse(this.totalPriceTextbox.Text) - double.Parse(this.paymentTextbox.Text.Trim());

                MessageBox.Show("Successfully save sale\nChange: " + Math.Abs(change));
                #endregion
            }
            else
            {
                MessageBox.Show("Fill out payment", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CustomerIsInDatabase(string name)
        {
            MySqlConnection connection = DBConnector.Connector();
            // open the connection
            connection.Open();

            string query = "SELECT * FROM customers WHERE name = '" + name + "'";
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            bool val = reader.HasRows;
            connection.Close();
            return val;
        }

        private void customerNameCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();

            // when the combobox value is null or empty
            // it would not proceed
            if (string.IsNullOrEmpty(productCombobox.Text.ToString()))
            {
                return;
            }
            conn.Open();

            string query = "SELECT phone_number " +
                "FROM customers " +
                "WHERE name = '" + customerNameCombobox.SelectedValue.ToString() + "'";
            var cmd = new MySqlCommand(query, conn);

            var reader = cmd.ExecuteReader();

            // check if there is already a customer named as the input
            // load the number
            BindingList<string> phoneList = new BindingList<string>();
            if (reader.HasRows)
            {
            
                while (reader.Read())
                {
                    phoneList.Add(reader.GetString(0));
                }

                customerPhoneCombobox.DataSource = phoneList;
                conn.Close();
                return;
            }
            customerPhoneCombobox.DataSource = null;
            conn.Close();

        }

        private void customerNameCombobox_TextChanged(object sender, EventArgs e)
        {
            _customerName = customerNameCombobox.Text;
        }

        private void customerPhoneCombobox_TextChanged(object sender, EventArgs e)
        {
            _customerPhone = customerPhoneCombobox.Text;
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

        private void ManagerSaleUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitializeAutoCompleteProduct();
                InitializeProductComboboxItems();
                InitializeCustomerComboboxItems();
            }
        }

        private void ManagerSaleUserControl_Load(object sender, EventArgs e)
        {
            ProductDAO productDao = new ProductDAO();
            productCombobox.DataSource = productDao.GetAvailableProducts();
            productCombobox.DisplayMember = "name";
        }

        private void productCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();
            conn.Open();

            string item = productCombobox.Text;

            string query = "SELECT * FROM products WHERE name = @item";

            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@item", item);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                unitPriceTextBox.Text = reader["retail_price"].ToString();
            }

            conn.Close();
        }
    }
}
