using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerCreditAnalyticsUserControl : UserControl
    {
        public ManagerCreditAnalyticsUserControl()
        {
            InitializeComponent();
            PopulateTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void PopulateTable()
        {
            MySqlConnection conn = DBConnector.Connector();

            conn.Open();

            string query = "SELECT " +
                "name as 'Customer Name', " +
                "phone_number as 'Phone Number', " +
                "amount_due as 'Amount Due' " +
                "FROM sales " +
                "JOIN customers ON sales.customer_id = customers.id " +
                "WHERE sales.amount_due > 0 " +
                "ORDER BY 3 DESC;";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            conn.Close();

            creditAnalyticsDatagridView.DataSource = table;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();

            conn.Open();

            string query = "SELECT " +
                "name as 'Customer Name', " +
                "phone_number as 'Phone Number', " +
                "amount_due as 'Amount Due' " +
                "FROM sales " +
                "JOIN customers ON sales.customer_id = customers.id " +
                "WHERE sales.amount_due > 0 AND name LIKE '%" + this.searchBar.Text.Trim() + "%' " +
                "ORDER BY 3 DESC;";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            conn.Close();

            creditAnalyticsDatagridView.DataSource = table;
        }
    }
}
