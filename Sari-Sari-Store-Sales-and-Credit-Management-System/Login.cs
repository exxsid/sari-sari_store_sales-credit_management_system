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


namespace Sari_Sari_Store_Sales_and_Credit_Management_System
{
    public partial class Login : Form
    {
        string connect = "server=localhost;port=3306;user=root;password='';database=sari-sari_store";

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string IDNumber = inputIDNumber.Text;
            string password = inputPassword.Text;

            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();

            string query = "SELECT * FROM user WHERE id = @IDNumber AND password = @Password";
            
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDNumber", IDNumber);
            command.Parameters.AddWithValue("@Password", password);

            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("User not found.");
                return;
            }

            while (reader.Read()) {

                string accountType = reader["user_type"].ToString();
                string name = reader["name"].ToString();

                if (accountType == "M")
                {
                    View.ManagerApp next = new View.ManagerApp(name);
                    next.Show();
                    this.Hide();

                }
                else if (accountType == "C")
                {
                    CashierDash next = new CashierDash(name);
                    next.Show();
                    this.Hide();
                }

            } 

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void inputIDNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
