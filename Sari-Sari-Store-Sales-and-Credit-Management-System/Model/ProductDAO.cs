using MySql.Data.MySqlClient;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    internal class ProductDAO
    {

        private MySqlConnection _connection;
        public ProductDAO()
        {
            // initialize the connection to database
            _connection = DBConnector.Connector();
        }

        public DataTable GetProducts()
        {
            DataTable dTable = new DataTable();

            _connection.Open();
            var cmd = new MySqlCommand("SELECT products.id, " +
                "products.name, " +
                "products.quantity, " +
                "products.retail_price, " +
                "purchase.wholesale_price, " +
                "products.status " +
                "FROM products " +
                "LEFT JOIN purchase ON purchase.product_id = products.id;", _connection);

            var reader = cmd.ExecuteReader();

            dTable.Load(reader);

            _connection.Close();

            return dTable;
        }

    }
}
