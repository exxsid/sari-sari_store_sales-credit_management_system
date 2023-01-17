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
using System.Runtime.InteropServices;

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

            ttlSaleReader.Read();
            // when there is no sales in the specified moth and year
            double totalSale = 0;
            if(ttlSaleReader.IsDBNull(0))
            {
                this.totalSaleDisplay.Text = "P 0";
            }
            else
            {
                totalSale = ttlSaleReader.GetDouble(0);
                this.totalSaleDisplay.Text = "P " + totalSale.ToString();
            }
            conn.Close();
            
            #endregion

            #region comparison
            // get the previous month
            DateTime prev = dateTimePicker.Value.AddMonths(-1);
            string prevMonth = prev.ToString("MM");
            string prevYear = prev.ToString("yyyy");
            conn.Open();
            string prevSaleQuery = "SELECT sum(price) FROM sale_details " +
                "JOIN sales ON sale_details.sale_id = sales.id " +
                "WHERE month(date) = @month AND year(date) = @year;";
            var prevSaleCmd = new MySqlCommand(prevSaleQuery, conn);
            prevSaleCmd.Parameters.AddWithValue("@month", prevMonth);
            prevSaleCmd.Parameters.AddWithValue("@year", prevYear);
            var prevReader = prevSaleCmd.ExecuteReader();

            prevReader.Read();
            double prevSale = 0;
            if (prevReader.IsDBNull(0))
            {
                // both previous and currrent sale is zero
                if (prevSale == 0 && totalSale == 0)
                {
                    this.comparisonDisplay.Text = "0%";
                }
                // the previous sale is the only zero
                else if (prevSale == 0)
                {
                    this.comparisonDisplay.Text = "100%";
                }
            }
            // previous sale more than zero
            else
            {
                // the current sale is zero
                if (totalSale == 0)
                {
                    this.comparisonDisplay.Text = "-100%";
                }
                // both previous and current sale is more than zero
                else
                {
                    prevSale = prevReader.GetDouble(0);
                    this.comparisonDisplay.Text = ((totalSale - prevSale) / prevSale * 100) + "%";
                }
            }

            conn.Close();
            #endregion

            PopulateTopSellingDataGrid(month, year);
        }

        private void PopulateTopSellingDataGrid(string month, string year)
        {
            MySqlConnection conn = DBConnector.Connector();
            conn.Open();

            string query = "SELECT products.name as 'Product Name', SUM(sale_details.price) as 'Total sale price' " +
                "FROM products " +
                "JOIN sale_details ON products.id = sale_details.product_id " +
                "JOIN sales ON sale_details.sale_id = sales.id " +
                "WHERE MONTH(sales.date) = @month AND year(sales.date) = @year " +
                "GROUP BY products.name;";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            if (!reader.HasRows)
            {
                conn.Close();
                MessageBox.Show("No Top-selling for this month");
                return;
            }
            table.Load(reader);
            
            topSellingDataGridView.DataSource = table;

            conn.Close();
        }
    }
}
