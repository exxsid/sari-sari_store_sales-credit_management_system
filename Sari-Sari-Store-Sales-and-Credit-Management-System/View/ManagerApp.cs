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

        public ManagerApp()
        {
            InitializeComponent();
        }

        private void ManagerApp_Load(object sender, EventArgs e)
        {
            // hide the analytics submenu in load time
            this.analyticsSubMenu.Visible = false;
        }

        #region homeButton
        private void homeButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.homeButton);
        }
        #endregion

        #region saleButton
        private void saleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.saleButton);
        }
        #endregion

        #region productsButton
        private void productsButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.productsButton);
        }
        #endregion

        #region usersButton
        private void usersButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // set the back color
            setToActiveButtonBackColor(this.usersButton);
        }
        #endregion

        #region analyticsButton
        private void analyticsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(this.analyticsSubMenu);
            // set the back color
            setToActiveButtonBackColor(this.analyticsButton);

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
