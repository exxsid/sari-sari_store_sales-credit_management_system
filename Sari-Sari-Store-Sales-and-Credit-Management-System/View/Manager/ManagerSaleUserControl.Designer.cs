namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    partial class ManagerSaleUserControl
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
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            this.custPhoneTextBox = new System.Windows.Forms.TextBox();
            this.productCombobox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceTextbox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentTextbox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(31, 28);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(120, 21);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(31, 72);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(123, 21);
            this.customerPhoneLabel.TabIndex = 1;
            this.customerPhoneLabel.Text = "Customer Phone";
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.Location = new System.Drawing.Point(157, 25);
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(201, 26);
            this.custNameTextBox.TabIndex = 2;
            // 
            // custPhoneTextBox
            // 
            this.custPhoneTextBox.Location = new System.Drawing.Point(157, 69);
            this.custPhoneTextBox.Name = "custPhoneTextBox";
            this.custPhoneTextBox.Size = new System.Drawing.Size(201, 26);
            this.custPhoneTextBox.TabIndex = 3;
            // 
            // productCombobox
            // 
            this.productCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productCombobox.FormattingEnabled = true;
            this.productCombobox.Items.AddRange(new object[] {
            "reyerye",
            "eryeye",
            "",
            "eryrey"});
            this.productCombobox.Location = new System.Drawing.Point(35, 129);
            this.productCombobox.Name = "productCombobox";
            this.productCombobox.Size = new System.Drawing.Size(250, 29);
            this.productCombobox.TabIndex = 4;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(129, 105);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(63, 21);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Product";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(291, 132);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(109, 26);
            this.quantityTextbox.TabIndex = 6;
            this.quantityTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextbox_KeyPress);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(311, 108);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 21);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quantity";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(426, 108);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(76, 21);
            this.unitPriceLabel.TabIndex = 9;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.unitPriceTextBox.Location = new System.Drawing.Point(406, 132);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.ReadOnly = true;
            this.unitPriceTextBox.Size = new System.Drawing.Size(109, 26);
            this.unitPriceTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(324, 324);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(82, 21);
            this.totalPriceLabel.TabIndex = 12;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // totalPriceTextbox
            // 
            this.totalPriceTextbox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.totalPriceTextbox.Location = new System.Drawing.Point(406, 321);
            this.totalPriceTextbox.Name = "totalPriceTextbox";
            this.totalPriceTextbox.ReadOnly = true;
            this.totalPriceTextbox.Size = new System.Drawing.Size(109, 26);
            this.totalPriceTextbox.TabIndex = 11;
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Location = new System.Drawing.Point(538, 129);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(114, 29);
            this.addProductButton.TabIndex = 13;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // removeProductButton
            // 
            this.removeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProductButton.Location = new System.Drawing.Point(538, 286);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(114, 29);
            this.removeProductButton.TabIndex = 14;
            this.removeProductButton.Text = "Remove";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(565, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 29);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(472, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // paymentTextbox
            // 
            this.paymentTextbox.Location = new System.Drawing.Point(451, 25);
            this.paymentTextbox.Name = "paymentTextbox";
            this.paymentTextbox.Size = new System.Drawing.Size(201, 26);
            this.paymentTextbox.TabIndex = 19;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(373, 28);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(72, 21);
            this.paymentLabel.TabIndex = 18;
            this.paymentLabel.Text = "Payment";
            // 
            // ManagerSaleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.paymentTextbox);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productCombobox);
            this.Controls.Add(this.custPhoneTextBox);
            this.Controls.Add(this.custNameTextBox);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerSaleUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.TextBox custPhoneTextBox;
        private System.Windows.Forms.ComboBox productCombobox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalPriceTextbox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox paymentTextbox;
        private System.Windows.Forms.Label paymentLabel;
    }
}
