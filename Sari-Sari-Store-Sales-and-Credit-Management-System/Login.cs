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
        string connect = "server=localhost;port=3306;user=root;password=12345;database=cms";

        public Login()
        {
            InitializeComponent();

            var color = System.Drawing.ColorTranslator.FromHtml("#03045E");
            pictureBox1.BackColor = color;
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
                CashierDash next = new CashierDash();
                next.Show();
                this.Hide();
            } else {
                MessageBox.Show("Error logging in!");
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
