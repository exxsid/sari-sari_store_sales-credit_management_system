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
    public partial class Form1 : Form
    {
        string connect = "server=localhost;port=3306;user=root;password=12345;database=cms";

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = inputUsername.Text;
            string password = inputPassword.Text;

            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();

            string query = "SELECT * FROM users WHERE Username = @username AND password = @password";
            
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) {
                Form3 next = new Form3();
                next.Show();
                this.Hide();
            } else {
                MessageBox.Show("Error logging in!");
            }

            connection.Close();
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            Form2 registration = new Form2();
            this.Hide();
            registration.Show();
        }
    }
}
