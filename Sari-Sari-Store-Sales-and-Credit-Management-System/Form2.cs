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
using Org.BouncyCastle.Cms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System
{
    public partial class Form2 : Form
    {
        string connect = "server=localhost;port=3306;user=root;password=12345;database=cms";
        public Form2()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string fName = inputFullname.Text;
            string uName = inputUsername.Text;
            string email = inputEmail.Text;
            string pass = inputPassword.Text;
            string confirm = inputConfirm.Text;

            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();

            if (String.Equals(pass, confirm))
            {
                string query = "INSERT INTO users (Fullname, Username, EmailAdd, Password) VALUES " +
                    "(@fullname, @username, @emailadd, @password)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fullname", fName);
                command.Parameters.AddWithValue("@username", uName);
                command.Parameters.AddWithValue("@emailadd", email);
                command.Parameters.AddWithValue("@password", pass);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration Succesful!");
                    inputFullname.Text = "";
                    inputUsername.Text = "";
                    inputEmail.Text = "";
                    inputPassword.Text = "";
                    inputConfirm.Text = "";
                }
                else
                {
                    MessageBox.Show("Registration Failed!");
                    inputFullname.Text = "";
                    inputUsername.Text = "";
                    inputEmail.Text = "";
                    inputPassword.Text = "";
                    inputConfirm.Text = "";
                }

                connection.Close();
            } else
            {
                MessageBox.Show("Passwords must match!");
            }
        }

        private void signinAcc_Click(object sender, EventArgs e)
        {
            Form1 signin = new Form1();
            this.Hide();
            signin.Show();
        }
    }
}
