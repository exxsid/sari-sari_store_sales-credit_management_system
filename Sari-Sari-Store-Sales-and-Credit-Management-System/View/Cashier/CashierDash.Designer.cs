﻿namespace Sari_Sari_Store_Sales_and_Credit_Management_System
{
    partial class CashierDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDash));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.saleButton = new FontAwesome.Sharp.IconButton();
            this.sideNavBar = new System.Windows.Forms.Panel();
            this.creditPaymentButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profileButton = new FontAwesome.Sharp.IconButton();
            this.cashierCreditPayment2 = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier.CashierCreditPaymentTab();
            this.cashierCreditPayment1 = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier.CashierCreditPaymentTab();
            this.cashierSaleTab1 = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier.CashierSaleTab();
            this.cashierHomeTab1 = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier.CashierHomeTab();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sideNavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 134);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 25;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 134);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.homeButton.Size = new System.Drawing.Size(194, 50);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // saleButton
            // 
            this.saleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saleButton.FlatAppearance.BorderSize = 0;
            this.saleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleButton.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.saleButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.saleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saleButton.IconSize = 25;
            this.saleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleButton.Location = new System.Drawing.Point(0, 184);
            this.saleButton.Name = "saleButton";
            this.saleButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.saleButton.Size = new System.Drawing.Size(194, 50);
            this.saleButton.TabIndex = 4;
            this.saleButton.Text = "Sale";
            this.saleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saleButton.UseVisualStyleBackColor = true;
            // 
            // sideNavBar
            // 
            this.sideNavBar.AutoScroll = true;
            this.sideNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.sideNavBar.Controls.Add(this.creditPaymentButton);
            this.sideNavBar.Controls.Add(this.saleButton);
            this.sideNavBar.Controls.Add(this.homeButton);
            this.sideNavBar.Controls.Add(this.panel2);
            this.sideNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavBar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNavBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.sideNavBar.Location = new System.Drawing.Point(0, 0);
            this.sideNavBar.Name = "sideNavBar";
            this.sideNavBar.Size = new System.Drawing.Size(194, 515);
            this.sideNavBar.TabIndex = 2;
            // 
            // creditPaymentButton
            // 
            this.creditPaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.creditPaymentButton.FlatAppearance.BorderSize = 0;
            this.creditPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditPaymentButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.creditPaymentButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.creditPaymentButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.creditPaymentButton.IconSize = 25;
            this.creditPaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditPaymentButton.Location = new System.Drawing.Point(0, 234);
            this.creditPaymentButton.Name = "creditPaymentButton";
            this.creditPaymentButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.creditPaymentButton.Size = new System.Drawing.Size(194, 50);
            this.creditPaymentButton.TabIndex = 10;
            this.creditPaymentButton.Text = "Credit Payment";
            this.creditPaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.creditPaymentButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 48);
            this.panel1.TabIndex = 3;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.logoutButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.logoutButton.IconSize = 25;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.Location = new System.Drawing.Point(570, 8);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(108, 33);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.usernameLabel.Location = new System.Drawing.Point(68, 14);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 21);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "user name";
            // 
            // profileButton
            // 
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.profileButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.profileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileButton.IconSize = 25;
            this.profileButton.Location = new System.Drawing.Point(6, 8);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(70, 33);
            this.profileButton.TabIndex = 0;
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // cashierCreditPayment2
            // 
            this.cashierCreditPayment2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.cashierCreditPayment2.Location = new System.Drawing.Point(776, 247);
            this.cashierCreditPayment2.Name = "cashierCreditPayment2";
            this.cashierCreditPayment2.Size = new System.Drawing.Size(69, 8);
            this.cashierCreditPayment2.TabIndex = 7;
            // 
            // cashierCreditPayment1
            // 
            this.cashierCreditPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.cashierCreditPayment1.Location = new System.Drawing.Point(194, 48);
            this.cashierCreditPayment1.Name = "cashierCreditPayment1";
            this.cashierCreditPayment1.Size = new System.Drawing.Size(722, 478);
            this.cashierCreditPayment1.TabIndex = 6;
            // 
            // cashierSaleTab1
            // 
            this.cashierSaleTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.cashierSaleTab1.Location = new System.Drawing.Point(194, 47);
            this.cashierSaleTab1.Name = "cashierSaleTab1";
            this.cashierSaleTab1.Size = new System.Drawing.Size(722, 478);
            this.cashierSaleTab1.TabIndex = 5;
            // 
            // cashierHomeTab1
            // 
            this.cashierHomeTab1.Location = new System.Drawing.Point(194, 48);
            this.cashierHomeTab1.Name = "cashierHomeTab1";
            this.cashierHomeTab1.Size = new System.Drawing.Size(722, 477);
            this.cashierHomeTab1.TabIndex = 4;
            // 
            // CashierDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.cashierCreditPayment2);
            this.Controls.Add(this.cashierCreditPayment1);
            this.Controls.Add(this.cashierSaleTab1);
            this.Controls.Add(this.cashierHomeTab1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashierDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDash";
            this.Load += new System.EventHandler(this.CashierDash_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sideNavBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton saleButton;
        private System.Windows.Forms.Panel sideNavBar;
        private FontAwesome.Sharp.IconButton creditPaymentButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton logoutButton;
        private System.Windows.Forms.Label usernameLabel;
        private FontAwesome.Sharp.IconButton profileButton;
        private View.Cashier.CashierHomeTab cashierHomeTab1;
        private View.Cashier.CashierSaleTab cashierSaleTab1;
        private View.Cashier.CashierCreditPaymentTab cashierCreditPayment1;
        private View.Cashier.CashierCreditPaymentTab cashierCreditPayment2;
    }
}