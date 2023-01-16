using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using System.Data;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.Model
{
    public class UserDAO
    {
        private MySqlConnection _connection;
        public UserDAO()
        { 
           // initialize the connection to database
           _connection = DBConnector.Connector();
        }

        public DataTable GetUsers()
        {
            DataTable dTable = new DataTable();

            _connection.Open();
            var cmd = new MySqlCommand("SELECT * FROM employees;", _connection);

            var reader = cmd.ExecuteReader();

            dTable.Load(reader);

            _connection.Close();

            return dTable;
        }
    }
}
