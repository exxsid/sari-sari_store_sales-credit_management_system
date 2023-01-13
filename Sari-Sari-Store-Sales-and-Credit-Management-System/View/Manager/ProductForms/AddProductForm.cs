using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        public Product Product { set { this.Product = value; } }
    }
}
