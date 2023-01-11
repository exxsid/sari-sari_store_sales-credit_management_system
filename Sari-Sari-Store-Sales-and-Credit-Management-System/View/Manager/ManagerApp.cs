using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View
{
    public partial class ManagerApp : Form
    {
        private System.Drawing.Color NONACTIVE_BUTTON_BACK_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
        private System.Drawing.Color ACTIVE_BUTTON_BACK_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));

        private string username;

        public ManagerApp(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ManagerApp_Load(object sender, EventArgs e)
        {
            // hide the analytics submenu in load time
            this.analyticsSubMenu.Visible = false;
            // at start time, home button is the defaul selected
            // set the home button's back color to active at start
            this.homeButton.BackColor = ACTIVE_BUTTON_BACK_COLOR;
            // show the home page
            this.managerHomeUserControl1.Show();
            this.managerHomeUserControl1.BringToFront();
            // then hide other page
            // TODO: other pages
            this.managerSaleUserControl1.Hide();
            this.managerProductsUserControl1.Hide();
            this.managerUsersUserControl1.Hide();

            // set the username in the usernameLabel
            this.usernameLabel.Text = this.username;
        }

        #region homeButton
        private void homeButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.homeButton);
            // show the home page
            this.managerHomeUserControl1.Show();
            this.managerHomeUserControl1.BringToFront();
            // then hide other page
            // TODO: other pages
            this.managerSaleUserControl1.Hide();
            this.managerProductsUserControl1.Hide();
            this.managerUsersUserControl1.Hide();
        }
        #endregion

        #region saleButton
        private void saleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.saleButton);

            // show the sale page
            this.managerSaleUserControl1.Show();
            this.managerSaleUserControl1.BringToFront();
            // then hide other page
            // TODO: other pages
            this.managerHomeUserControl1.Hide();
            this.managerProductsUserControl1.Hide();
            this.managerUsersUserControl1.Hide();
        }
        #endregion

        #region productsButton
        private void productsButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.productsButton);

            // show the products page
            this.managerProductsUserControl1.Show();
            this.managerProductsUserControl1.BringToFront();
            // then hide other page
            // TODO: other pages
            this.managerHomeUserControl1.Hide();
            this.managerSaleUserControl1.Hide();
            this.managerUsersUserControl1.Hide();
        }
        #endregion

        #region usersButton
        private void usersButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.usersButton);

            // show the users page
            this.managerUsersUserControl1.Show();
            this.managerUsersUserControl1.BringToFront();
            // then hide other page
            // TODO: other pages
            this.managerHomeUserControl1.Hide();
            this.managerSaleUserControl1.Hide();
            this.managerProductsUserControl1.Hide();
        }
        #endregion

        #region analyticsButton
        private void analyticsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(this.analyticsSubMenu);
            // set the back color
            setToActiveButtonBackColor(this.analyticsButton);

            

        }

        private void salesAnalyticsButton_Click(object sender, EventArgs e)
        {
            // TODO: place it in specific analytics
            // show the analytics page

            // then hide other page
            this.managerHomeUserControl1.Hide();
            this.managerSaleUserControl1.Hide();
            this.managerProductsUserControl1.Hide();
            this.managerUsersUserControl1.Hide();
        }

        private void creditAnalyticsButton_Click(object sender, EventArgs e)
        {
            // TODO: place it in specific analytics
            // show the analytics page

            // then hide other page
            this.managerHomeUserControl1.Hide();
            this.managerSaleUserControl1.Hide();
            this.managerProductsUserControl1.Hide();
            this.managerUsersUserControl1.Hide();
        }
        #endregion

        private void hideSubMenu()
        {
            // hide the analytics submenu when other button is clicked
            if (this.analyticsSubMenu.Visible)
            {
                this.analyticsSubMenu.Visible = false;
            }
        }


        private void showSubMenu(Panel subMenu)
        {
            // // hide the analytics submenu when the specified button is clicked
            if (!subMenu.Visible)
            {
                hideSubMenu();// closed the submenu that is shown
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

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

            if (this.productsButton.BackColor == ACTIVE_BUTTON_BACK_COLOR)
            {
                this.productsButton.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
            }

            if (this.usersButton.BackColor == ACTIVE_BUTTON_BACK_COLOR)
            {
                this.usersButton.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
            }

            if (this.analyticsButton.BackColor == ACTIVE_BUTTON_BACK_COLOR)
            {
                this.analyticsButton.BackColor = NONACTIVE_BUTTON_BACK_COLOR;
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

    }
}
