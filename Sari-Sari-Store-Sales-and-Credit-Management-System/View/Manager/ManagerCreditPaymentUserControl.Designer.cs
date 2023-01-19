namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    partial class ManagerCreditPaymentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameCombox = new System.Windows.Forms.ComboBox();
            this.phoneCombox = new System.Windows.Forms.ComboBox();
            this.paymentTextbox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.creditAmoutLabel = new System.Windows.Forms.Label();
            this.creditAmountTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(172, 68);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(112, 20);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(168, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Phone";
            // 
            // nameCombox
            // 
            this.nameCombox.FormattingEnabled = true;
            this.nameCombox.Location = new System.Drawing.Point(291, 65);
            this.nameCombox.Name = "nameCombox";
            this.nameCombox.Size = new System.Drawing.Size(185, 28);
            this.nameCombox.TabIndex = 2;
            this.nameCombox.SelectedValueChanged += new System.EventHandler(this.nameCombox_SelectedValueChanged);
            // 
            // phoneCombox
            // 
            this.phoneCombox.FormattingEnabled = true;
            this.phoneCombox.Location = new System.Drawing.Point(291, 126);
            this.phoneCombox.Name = "phoneCombox";
            this.phoneCombox.Size = new System.Drawing.Size(185, 28);
            this.phoneCombox.TabIndex = 3;
            // 
            // paymentTextbox
            // 
            this.paymentTextbox.Location = new System.Drawing.Point(291, 245);
            this.paymentTextbox.Name = "paymentTextbox";
            this.paymentTextbox.Size = new System.Drawing.Size(185, 25);
            this.paymentTextbox.TabIndex = 4;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentLabel.Location = new System.Drawing.Point(173, 248);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(65, 20);
            this.paymentLabel.TabIndex = 5;
            this.paymentLabel.Text = "Payment";
            // 
            // creditAmoutLabel
            // 
            this.creditAmoutLabel.AutoSize = true;
            this.creditAmoutLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditAmoutLabel.Location = new System.Drawing.Point(173, 188);
            this.creditAmoutLabel.Name = "creditAmoutLabel";
            this.creditAmoutLabel.Size = new System.Drawing.Size(102, 20);
            this.creditAmoutLabel.TabIndex = 6;
            this.creditAmoutLabel.Text = "Credit Amount";
            // 
            // creditAmountTextBox
            // 
            this.creditAmountTextBox.Enabled = false;
            this.creditAmountTextBox.Location = new System.Drawing.Point(291, 187);
            this.creditAmountTextBox.Name = "creditAmountTextBox";
            this.creditAmountTextBox.Size = new System.Drawing.Size(185, 25);
            this.creditAmountTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(308, 301);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(401, 301);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ManagerCreditPaymentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.creditAmountTextBox);
            this.Controls.Add(this.creditAmoutLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.paymentTextbox);
            this.Controls.Add(this.phoneCombox);
            this.Controls.Add(this.nameCombox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerCreditPaymentUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameCombox;
        private System.Windows.Forms.ComboBox phoneCombox;
        private System.Windows.Forms.TextBox paymentTextbox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label creditAmoutLabel;
        private System.Windows.Forms.TextBox creditAmountTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
