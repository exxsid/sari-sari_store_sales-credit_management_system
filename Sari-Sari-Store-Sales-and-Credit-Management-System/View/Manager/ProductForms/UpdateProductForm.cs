using Sari_Sari_Store_Sales_and_Credit_Management_System.Model;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms
{
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        public Product Product { set { this.Product = value; } }
    }
}
