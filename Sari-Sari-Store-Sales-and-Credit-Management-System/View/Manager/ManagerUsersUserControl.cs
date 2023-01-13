using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.UserForms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    public partial class ManagerUsersUserControl : UserControl
    {
        public ManagerUsersUserControl()
        {
            InitializeComponent();
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
                User updateUser = new User();
                updateUser.Id = int.Parse(selectedRow.Cells["id"].Value.ToString());
                updateUser.Name = selectedRow.Cells["name"].Value.ToString();
                updateUser.Password = selectedRow.Cells["password"].Value.ToString();
                updateUser.UserType = selectedRow.Cells["user_type"].Value.ToString().ElementAt(0);

                UpdateUserForm updateUserForm = new UpdateUserForm();
                updateUserForm.User = updateUser;

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
    }
}
