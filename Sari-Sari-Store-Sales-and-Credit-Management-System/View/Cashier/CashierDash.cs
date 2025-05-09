﻿using System;
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
        private System.Drawing.Color NONACTIVE_BUTTON_BACK_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
        private System.Drawing.Color ACTIVE_BUTTON_BACK_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));

        private string cashier;
        private Form FromPage;

        public CashierDash(string cashier, Form fromPage)
        {
            InitializeComponent();
            this.cashier = cashier;
            FromPage = fromPage;
        }

        private void CashierDash_Load(object sender, EventArgs e)
        {

            // at start time, home button is the defaul selected
            // set the home button's back color to active at start
            this.homeButton.BackColor = ACTIVE_BUTTON_BACK_COLOR;

            // show the home page
            this.cashierHomeTab1.Show();
            this.cashierHomeTab1.BringToFront();
            // then hide other page
            this.managerCreditPaymentUserControl1.Hide();
            this.managerSaleUserControl1.Hide();

            // set the username in the usernameLabel
            this.usernameLabel.Text = this.cashier;

        }

        #region homeButton
        private void homeButton_Click(object sender, EventArgs e)
        {
            // set the back color
            setToActiveButtonBackColor(this.homeButton);

            // show the home page
            this.cashierHomeTab1.Show();
            this.cashierHomeTab1.BringToFront();
            // then hide other page
            this.managerCreditPaymentUserControl1.Hide();
            this.managerSaleUserControl1.Hide(); ;
        }
        #endregion

        #region saleButton
        private void saleButton_Click_1(object sender, EventArgs e)
        {
            // set the back color
            setToActiveButtonBackColor(this.saleButton);

            // show the sale page
            this.managerSaleUserControl1.Show();
            this.managerSaleUserControl1.BringToFront();
            // then hide other page
            this.cashierHomeTab1.Hide();
            this.managerCreditPaymentUserControl1.Hide();
        }
        #endregion

        #region creditPaymentButton
        private void creditPaymentButton_Click_1(object sender, EventArgs e)
        {
            // set the back color
            setToActiveButtonBackColor(this.creditPaymentButton);

            // show the home page
            this.managerCreditPaymentUserControl1.Show();
            this.managerCreditPaymentUserControl1.BringToFront();
            // then hide other page
            this.managerSaleUserControl1.Hide();
            this.cashierHomeTab1.Hide();
        }
        #endregion

        private void setToNonActiveButtonBackColor()
        {
            if (this.homeButton.BackColor == ACTIVE_BUTTON_BACK_COLOR)
            {
                this.homeButton.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
            }

            if (this.saleButton.BackColor == ACTIVE_BUTTON_BACK_COLOR)
            {
                this.saleButton.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
            }

            if (this.creditPaymentButton.BackColor == ACTIVE_BUTTON_BACK_COLOR)
            {
                this.creditPaymentButton.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
            }
        }

        private void setToActiveButtonBackColor(Button button)
        {
            // when the button is not active the 
            if (button.BackColor == NONACTIVE_BUTTON_BACK_COLOR)
            {
                setToNonActiveButtonBackColor();
                button.BackColor = ACTIVE_BUTTON_BACK_COLOR;
            }
            else
            {
                button.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
            }
        }

        private void CashierDash_VisibleChanged(object sender, EventArgs e)
        {
            FromPage.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // message box changing status of the product
            DialogResult cancelConfirmation = MessageBox.Show("Are you sure you want to logout?",
                                   "Confirmation", MessageBoxButtons.OKCancel);
            // when the user click cancel
            // the new user form will not close
            if (cancelConfirmation == DialogResult.Cancel)
            {
                return;
            }
            this.Close();
        }

        private void CashierDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            FromPage.Show();
        }

        //usernameLabel.Text = cashier;
        //   this.cashierHomeTab1.Show();
        //   this.cashierHomeTab1.BringToFront();
    }
}
