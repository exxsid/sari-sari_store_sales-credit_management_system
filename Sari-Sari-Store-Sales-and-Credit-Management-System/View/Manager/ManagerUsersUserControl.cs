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
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.UserForms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerUsersUserControl : UserControl
    {
        private MySqlConnection _connection;
        public ManagerUsersUserControl()
        {
            InitializeComponent();
        }

        private void ManagerUsersUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                // initialize the connection to database
                _connection = DBConnector.Connector();
                _connection.Open();

                _connection.Close();

                PopulateUsersTable();
            }
            catch (Exception)
            {
                // when there is error in connection to the database
                MessageBox.Show("Fail to connect to database users");
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = usersDataGridView.SelectedRows[0];

                // create a Produc object
                // store values from the selected row
                User updateUser = new User(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),
                    selectedRow.Cells[1].Value.ToString(),
                    selectedRow.Cells[2].Value.ToString(),
                    selectedRow.Cells[3].Value.ToString()
                    );
                //updateUser.Id = int.Parse(selectedRow.Cells[0].Value.ToString());
                //updateUser.Name = selectedRow.Cells[1].Value.ToString();
                //updateUser.Password = selectedRow.Cells[3].Value.ToString();
                //updateUser.UserType = selectedRow.Cells[2].Value.ToString();

                UpdateUserForm updateUserForm = new UpdateUserForm(updateUser);

                updateUserForm.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a row", "Tip",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // message box employee deletion
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to delete the employee?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }

            // Delete the selected employee employee
            _connection.Open();

            string query = "DELETE FROM employees WHERE id = @id;";
            var cmd = new MySqlCommand(query, _connection);
            cmd.Parameters.AddWithValue("@id", this.usersDataGridView.SelectedRows[0]
                        .Cells[0]
                        .Value);

            int result = cmd.ExecuteNonQuery();
            if (result == -1)
            {
                _connection.Close();
                MessageBox.Show("Unable to delete the user");
                return;
            }
            _connection.Close();
            MessageBox.Show("Successfuly deleted the user");

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateUsersTable();
        }

        private void PopulateUsersTable()
        {
            // load the data grid view
            UserDAO userDAO = new UserDAO();
            usersDataGridView.DataSource = userDAO.GetUsers();
            SetTableHeader();
        }

        private void SetTableHeader()
        {
            usersDataGridView.Columns[0].HeaderText = "ID";
            usersDataGridView.Columns[1].HeaderText = "Name";
            usersDataGridView.Columns[2].HeaderText = "Employee Type";
            usersDataGridView.Columns[3].HeaderText = "Password";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _connection.Open();

            if (string.IsNullOrEmpty(searchBar.Text.Trim()))
            {
                MessageBox.Show("Fill out the search bar.");
                _connection.Close();
                return;
            }

            string query = "SELECT * " +
                "FROM employees " +
                "WHERE name LIKE '%" + searchBar.Text.Trim() + "%';";
            var cmd = new MySqlCommand(query, _connection);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            usersDataGridView.DataSource = table;
            _connection.Close();
            SetTableHeader();
        }
    }
}
