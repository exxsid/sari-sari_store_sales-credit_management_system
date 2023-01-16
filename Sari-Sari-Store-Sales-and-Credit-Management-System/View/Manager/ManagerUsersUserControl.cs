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
                // TODO: check again the cell name
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
            // TODO: message box User deletion
        }

        private void refreshButton_Click(object sender, EventArgs e)
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
    }
}
