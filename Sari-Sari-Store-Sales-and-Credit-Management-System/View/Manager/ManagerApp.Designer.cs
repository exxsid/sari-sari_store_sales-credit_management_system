namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View
{
    partial class ManagerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerApp));
            this.sideNavBar = new System.Windows.Forms.Panel();
            this.analyticsSubMenu = new System.Windows.Forms.Panel();
            this.creditAnalyticsButton = new FontAwesome.Sharp.IconButton();
            this.salesAnalyticsButton = new FontAwesome.Sharp.IconButton();
            this.analyticsButton = new FontAwesome.Sharp.IconButton();
            this.usersButton = new FontAwesome.Sharp.IconButton();
            this.productsButton = new FontAwesome.Sharp.IconButton();
            this.saleButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profileButton = new FontAwesome.Sharp.IconButton();
            this.sideNavBar.SuspendLayout();
            this.analyticsSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideNavBar
            // 
            this.sideNavBar.AutoScroll = true;
            this.sideNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.sideNavBar.Controls.Add(this.analyticsSubMenu);
            this.sideNavBar.Controls.Add(this.analyticsButton);
            this.sideNavBar.Controls.Add(this.usersButton);
            this.sideNavBar.Controls.Add(this.productsButton);
            this.sideNavBar.Controls.Add(this.saleButton);
            this.sideNavBar.Controls.Add(this.homeButton);
            this.sideNavBar.Controls.Add(this.panel2);
            this.sideNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavBar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNavBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.sideNavBar.Location = new System.Drawing.Point(0, 0);
            this.sideNavBar.Name = "sideNavBar";
            this.sideNavBar.Size = new System.Drawing.Size(194, 476);
            this.sideNavBar.TabIndex = 0;
            // 
            // analyticsSubMenu
            // 
            this.analyticsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.analyticsSubMenu.Controls.Add(this.creditAnalyticsButton);
            this.analyticsSubMenu.Controls.Add(this.salesAnalyticsButton);
            this.analyticsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.analyticsSubMenu.Location = new System.Drawing.Point(0, 384);
            this.analyticsSubMenu.Name = "analyticsSubMenu";
            this.analyticsSubMenu.Size = new System.Drawing.Size(194, 90);
            this.analyticsSubMenu.TabIndex = 8;
            // 
            // creditAnalyticsButton
            // 
            this.creditAnalyticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.creditAnalyticsButton.FlatAppearance.BorderSize = 0;
            this.creditAnalyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditAnalyticsButton.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.creditAnalyticsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.creditAnalyticsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.creditAnalyticsButton.IconSize = 25;
            this.creditAnalyticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditAnalyticsButton.Location = new System.Drawing.Point(0, 38);
            this.creditAnalyticsButton.Name = "creditAnalyticsButton";
            this.creditAnalyticsButton.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.creditAnalyticsButton.Size = new System.Drawing.Size(194, 38);
            this.creditAnalyticsButton.TabIndex = 9;
            this.creditAnalyticsButton.Text = "Credits Analytics";
            this.creditAnalyticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.creditAnalyticsButton.UseVisualStyleBackColor = true;
            // 
            // salesAnalyticsButton
            // 
            this.salesAnalyticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesAnalyticsButton.FlatAppearance.BorderSize = 0;
            this.salesAnalyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesAnalyticsButton.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.salesAnalyticsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.salesAnalyticsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salesAnalyticsButton.IconSize = 25;
            this.salesAnalyticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesAnalyticsButton.Location = new System.Drawing.Point(0, 0);
            this.salesAnalyticsButton.Name = "salesAnalyticsButton";
            this.salesAnalyticsButton.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.salesAnalyticsButton.Size = new System.Drawing.Size(194, 38);
            this.salesAnalyticsButton.TabIndex = 8;
            this.salesAnalyticsButton.Text = "Sales Analytics";
            this.salesAnalyticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesAnalyticsButton.UseVisualStyleBackColor = true;
            // 
            // analyticsButton
            // 
            this.analyticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.analyticsButton.FlatAppearance.BorderSize = 0;
            this.analyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticsButton.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.analyticsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.analyticsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.analyticsButton.IconSize = 25;
            this.analyticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyticsButton.Location = new System.Drawing.Point(0, 334);
            this.analyticsButton.Name = "analyticsButton";
            this.analyticsButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.analyticsButton.Size = new System.Drawing.Size(194, 50);
            this.analyticsButton.TabIndex = 7;
            this.analyticsButton.Text = "Analytics";
            this.analyticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.analyticsButton.UseVisualStyleBackColor = true;
            this.analyticsButton.Click += new System.EventHandler(this.analyticsButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.usersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.usersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersButton.IconSize = 25;
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(0, 284);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.usersButton.Size = new System.Drawing.Size(194, 50);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.productsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.productsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productsButton.IconSize = 25;
            this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.Location = new System.Drawing.Point(0, 234);
            this.productsButton.Name = "productsButton";
            this.productsButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productsButton.Size = new System.Drawing.Size(194, 50);
            this.productsButton.TabIndex = 5;
            this.productsButton.Text = "Products";
            this.productsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
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
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
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
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
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
            // ManagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideNavBar);
            this.Name = "ManagerApp";
            this.Text = "ManagerApp";
            this.Load += new System.EventHandler(this.ManagerApp_Load);
            this.sideNavBar.ResumeLayout(false);
            this.analyticsSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideNavBar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton productsButton;
        private FontAwesome.Sharp.IconButton saleButton;
        private FontAwesome.Sharp.IconButton usersButton;
        private FontAwesome.Sharp.IconButton analyticsButton;
        private System.Windows.Forms.Panel analyticsSubMenu;
        private FontAwesome.Sharp.IconButton creditAnalyticsButton;
        private FontAwesome.Sharp.IconButton salesAnalyticsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private FontAwesome.Sharp.IconButton profileButton;
        private FontAwesome.Sharp.IconButton logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}