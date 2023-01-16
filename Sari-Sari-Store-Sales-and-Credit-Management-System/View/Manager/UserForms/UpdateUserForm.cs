using System.Windows.Forms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Misc;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.UserForms
{
    public partial class UpdateUserForm : Form
    {


        private User User;
        private int origId;
        public UpdateUserForm(User user)
        {
            InitializeComponent();
            this.User = user;
            // store the original id when the id would be updated
            this.origId = user.GetId();
            this.idTextbox.Text = user.GetId().ToString();
            this.nameTextbox.Text = user.GetName();
            this.passwordTextbox.Text = user.GetPassword();
            this.typeCombobox.Text = user.GetEmployeeType();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
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

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            MySqlConnection connection = DBConnector.Connector();
            connection.Open();

            string query = "UPDATE employees " +
                "SET id = @id, " +
                "name = @name, " +
                "employee_type = @empType, " +
                "password = @password " +
                "WHERE id = @origId;";
            var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", this.idTextbox.Text);
            cmd.Parameters.AddWithValue("@name", this.nameTextbox.Text);
            cmd.Parameters.AddWithValue("@empType", this.typeCombobox.Text);
            cmd.Parameters.AddWithValue("@password", this.passwordTextbox.Text);
            cmd.Parameters.AddWithValue("@origID", this.origId);

            var reader = cmd.ExecuteNonQuery();
            if (reader == -1)
            {
                connection.Close();
                MessageBox.Show("Unable to update the employee");
                return;
            }

            // when the update is successful
            connection.Close();

            MessageBox.Show("Employee succesfuly Updated", "Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
