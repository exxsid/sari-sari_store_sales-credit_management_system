using System.Windows.Forms;
using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.UserForms
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        public User User { set { this.User = value; } }
    }
}
