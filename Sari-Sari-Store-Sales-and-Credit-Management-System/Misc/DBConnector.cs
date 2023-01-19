using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Misc
{
    public class DBConnector
    {
        public static MySqlConnection Connector()
        {
            var connector = new MySqlConnection();
            connector.ConnectionString = "Server=localhost;Database=minimart;Uid=root";
            return connector;
        }
    }
}
