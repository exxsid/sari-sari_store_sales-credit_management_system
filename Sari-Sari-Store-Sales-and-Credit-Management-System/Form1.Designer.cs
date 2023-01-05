namespace Sari_Sari_Store_Sales_and_Credit_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signinAcc = new System.Windows.Forms.Button();
            this.createAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.forgotPass = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signinAcc
            // 
            this.signinAcc.BackColor = System.Drawing.Color.SteelBlue;
            this.signinAcc.Cursor = System.Windows.Forms.Cursors.No;
            this.signinAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinAcc.ForeColor = System.Drawing.Color.White;
            this.signinAcc.Location = new System.Drawing.Point(533, 78);
            this.signinAcc.Name = "signinAcc";
            this.signinAcc.Size = new System.Drawing.Size(108, 34);
            this.signinAcc.TabIndex = 0;
            this.signinAcc.Text = "Sign In";
            this.signinAcc.UseVisualStyleBackColor = false;
            // 
            // createAcc
            // 
            this.createAcc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.createAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAcc.Location = new System.Drawing.Point(643, 78);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(108, 34);
            this.createAcc.TabIndex = 1;
            this.createAcc.Text = "Create Account";
            this.createAcc.UseVisualStyleBackColor = false;
            this.createAcc.Click += new System.EventHandler(this.createAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign in your account to continue ...";
            // 
            // inputUsername
            // 
            this.inputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputUsername.Font = new System.Drawing.Font("JetBrains Mono NL ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.Location = new System.Drawing.Point(495, 190);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(281, 33);
            this.inputUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // inputPassword
            // 
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPassword.Font = new System.Drawing.Font("JetBrains Mono NL ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(495, 250);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(281, 33);
            this.inputPassword.TabIndex = 5;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // forgotPass
            // 
            this.forgotPass.AutoSize = true;
            this.forgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPass.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.forgotPass.Location = new System.Drawing.Point(640, 289);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(136, 17);
            this.forgotPass.TabIndex = 7;
            this.forgotPass.Text = "Forgot Password?";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginButton.Location = new System.Drawing.Point(565, 320);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(149, 36);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 455);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 94);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sari-sari Store Sales and\r\nCredit Management System ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgotPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.signinAcc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinAcc;
        private System.Windows.Forms.Button createAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label forgotPass;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

