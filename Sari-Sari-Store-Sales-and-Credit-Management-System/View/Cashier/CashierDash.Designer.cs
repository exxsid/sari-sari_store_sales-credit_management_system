namespace Sari_Sari_Store_Sales_and_Credit_Management_System
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
            this.cashierHomeTab1 = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier.CashierHomeTab();
            this.saleUserControl = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ManagerSaleUserControl();
            this.creditPaymentUserControl1 = new Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ManagerCreditPaymentUserControl();
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
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
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
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click_1);
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
            this.sideNavBar.Size = new System.Drawing.Size(194, 476);
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
            this.creditPaymentButton.Click += new System.EventHandler(this.creditPaymentButton_Click_1);
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
            this.panel1.Size = new System.Drawing.Size(690, 48);
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
            this.logoutButton.Location = new System.Drawing.Point(554, 8);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(108, 33);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // cashierHomeTab1
            // 
            this.cashierHomeTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashierHomeTab1.Location = new System.Drawing.Point(194, 48);
            this.cashierHomeTab1.Name = "cashierHomeTab1";
            this.cashierHomeTab1.Size = new System.Drawing.Size(690, 428);
            this.cashierHomeTab1.TabIndex = 4;
            // 
            // saleUserControl
            // 
            this.saleUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.saleUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleUserControl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleUserControl.Location = new System.Drawing.Point(194, 48);
            this.saleUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saleUserControl.Name = "saleUserControl";
            this.saleUserControl.Size = new System.Drawing.Size(690, 428);
            this.saleUserControl.TabIndex = 8;
            // 
            // creditPaymentUserControl1
            // 
            this.creditPaymentUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.creditPaymentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditPaymentUserControl1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditPaymentUserControl1.Location = new System.Drawing.Point(194, 48);
            this.creditPaymentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.creditPaymentUserControl1.Name = "creditPaymentUserControl1";
            this.creditPaymentUserControl1.Size = new System.Drawing.Size(690, 428);
            this.creditPaymentUserControl1.TabIndex = 9;
            // 
            // CashierDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 476);
            this.Controls.Add(this.creditPaymentUserControl1);
            this.Controls.Add(this.saleUserControl);
            this.Controls.Add(this.cashierCreditPayment2);
            this.Controls.Add(this.cashierHomeTab1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashierDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashierDash_FormClosing);
            this.Load += new System.EventHandler(this.CashierDash_Load);
            this.VisibleChanged += new System.EventHandler(this.CashierDash_VisibleChanged);
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
        private View.Cashier.CashierCreditPaymentTab cashierCreditPayment2;
        private View.Manager.ManagerSaleUserControl saleUserControl;
        private View.Manager.ManagerCreditPaymentUserControl creditPaymentUserControl1;
    }
}