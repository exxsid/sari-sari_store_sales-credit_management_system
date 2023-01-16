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
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.UserForms
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBConnector.Connector();
            // open the connection
            connection.Open();

            string query = "INSERT INTO employees (name, employee_type, password) " +
                "VALUE (@name, @empType, @password);";
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", this.nameTextbox.Text);
            cmd.Parameters.AddWithValue("@empType", this.typeCombobox.Text);
            cmd.Parameters.AddWithValue("@password", this.passwordTextbox.Text);

            var result = cmd.ExecuteNonQuery();
            if(result == -1)
            {
                connection.Close();
                MessageBox.Show("Unable to add the new employee");
                return;
            }
            // when the insertion of new employee is successful
            connection.Close();

            MessageBox.Show("Employee succesfuly Updated", "Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to exit?", 
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            this.Close();
        }
    }
}
