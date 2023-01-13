using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System
{
    public partial class CashierDash : Form
    {
        private string cashier;
        public CashierDash(string cashier)
        {
            InitializeComponent();
            this.cashier= cashier;
        }

        private void CashierDash_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = cashier;
            this.cashierHomeTab1.Show();
            this.cashierHomeTab1.BringToFront();
        }
    }
}
