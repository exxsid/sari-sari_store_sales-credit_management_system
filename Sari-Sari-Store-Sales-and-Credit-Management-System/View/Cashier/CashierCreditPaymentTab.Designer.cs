namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Cashier
{
    partial class CashierCreditPaymentTab
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.creditAmountTextBox = new System.Windows.Forms.TextBox();
            this.creditAmoutLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.paymentTextbox = new System.Windows.Forms.TextBox();
            this.phoneCombox = new System.Windows.Forms.ComboBox();
            this.nameCombox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(416, 303);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(323, 303);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // creditAmountTextBox
            // 
            this.creditAmountTextBox.Location = new System.Drawing.Point(306, 189);
            this.creditAmountTextBox.Name = "creditAmountTextBox";
            this.creditAmountTextBox.ReadOnly = true;
            this.creditAmountTextBox.Size = new System.Drawing.Size(185, 20);
            this.creditAmountTextBox.TabIndex = 17;
            // 
            // creditAmoutLabel
            // 
            this.creditAmoutLabel.AutoSize = true;
            this.creditAmoutLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditAmoutLabel.Location = new System.Drawing.Point(188, 190);
            this.creditAmoutLabel.Name = "creditAmoutLabel";
            this.creditAmoutLabel.Size = new System.Drawing.Size(73, 13);
            this.creditAmoutLabel.TabIndex = 16;
            this.creditAmoutLabel.Text = "Credit Amount";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentLabel.Location = new System.Drawing.Point(188, 250);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(48, 13);
            this.paymentLabel.TabIndex = 15;
            this.paymentLabel.Text = "Payment";
            // 
            // paymentTextbox
            // 
            this.paymentTextbox.Location = new System.Drawing.Point(306, 247);
            this.paymentTextbox.Name = "paymentTextbox";
            this.paymentTextbox.Size = new System.Drawing.Size(185, 20);
            this.paymentTextbox.TabIndex = 14;
            // 
            // phoneCombox
            // 
            this.phoneCombox.FormattingEnabled = true;
            this.phoneCombox.Location = new System.Drawing.Point(306, 128);
            this.phoneCombox.Name = "phoneCombox";
            this.phoneCombox.Size = new System.Drawing.Size(185, 21);
            this.phoneCombox.TabIndex = 13;
            // 
            // nameCombox
            // 
            this.nameCombox.FormattingEnabled = true;
            this.nameCombox.Location = new System.Drawing.Point(306, 67);
            this.nameCombox.Name = "nameCombox";
            this.nameCombox.Size = new System.Drawing.Size(185, 21);
            this.nameCombox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(183, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Phone";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(187, 70);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 10;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // CashierCreditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Name = "CashierCreditPayment";
            this.Size = new System.Drawing.Size(675, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox creditAmountTextBox;
        private System.Windows.Forms.Label creditAmoutLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox paymentTextbox;
        private System.Windows.Forms.ComboBox phoneCombox;
        private System.Windows.Forms.ComboBox nameCombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerNameLabel;
    }
}
