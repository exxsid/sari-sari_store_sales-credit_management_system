using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        public Product Product { set { this.Product = value; } }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            // TODO: implement saving new product
        }
    }
}
