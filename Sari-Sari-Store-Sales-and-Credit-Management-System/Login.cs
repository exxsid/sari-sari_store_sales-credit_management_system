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
        string connect = "server=localhost;port=3306;user=root;password='';database=minimart";

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

            string query = "SELECT * FROM accounts WHERE IDNumber = @IDNumber AND password = @Password";
            
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDNumber", IDNumber);
            command.Parameters.AddWithValue("@Password", password);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {

                string accountType = reader["AccountType"].ToString();
                string name = reader["Name"].ToString();

                if (accountType == "Manager")
                {
                    View.ManagerApp next = new View.ManagerApp(name);
                    next.Show();
                    this.Hide();

                }
                else if (accountType == "Cashier")
                {
                    CashierDash next = new CashierDash(name);
                    next.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error logging in!");
                }

            } 

            connection.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
