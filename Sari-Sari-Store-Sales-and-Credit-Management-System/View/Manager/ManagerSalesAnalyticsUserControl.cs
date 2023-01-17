using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using MySql.Data.MySqlClient;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerSalesAnalyticsUserControl : UserControl
    {
        public ManagerSalesAnalyticsUserControl()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnector.Connector();
            // get the month from the datetimepicker
            string month = dateTimePicker.Value.ToString("MM");
            // get the year from the datetimepicker
            string year = dateTimePicker.Value.ToString("yyyy");

            #region total sales
            // get the total sales
            conn.Open();
            string totalSaleQuery = "SELECT sum(price) FROM sale_details " +
                "JOIN sales ON sale_details.sale_id = sales.id " +
                "WHERE month(date) = @month AND year(date) = @year;";
            var totalSaleCmd = new MySqlCommand(totalSaleQuery, conn);
            totalSaleCmd.Parameters.AddWithValue("@month", month);
            totalSaleCmd.Parameters.AddWithValue("@year", year);
            var ttlSaleReader = totalSaleCmd.ExecuteReader();

            // when there is no sales in the specified moth and year
            ttlSaleReader.Read();
            if(ttlSaleReader.IsDBNull(0))
            {
                conn.Close();
                this.totalSaleDisplay.Text = "P " + 0;
                return;
            }

            double totalSale = ttlSaleReader.GetDouble(0);
            this.totalSaleDisplay.Text = "P " + totalSale.ToString();

            conn.Close();
            #endregion

            
        }
    }
}
