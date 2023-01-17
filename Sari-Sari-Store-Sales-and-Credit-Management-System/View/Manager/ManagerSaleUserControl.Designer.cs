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
            this.productCombobox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.saleDataGridView = new System.Windows.Forms.DataGridView();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceTextbox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.paymentTextbox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.customerNameCombobox = new System.Windows.Forms.ComboBox();
            this.customerPhoneCombobox = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
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
            // productCombobox
            // 
            this.productCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productCombobox.FormattingEnabled = true;
            this.productCombobox.Location = new System.Drawing.Point(35, 129);
            this.productCombobox.Name = "productCombobox";
            this.productCombobox.Size = new System.Drawing.Size(250, 29);
            this.productCombobox.TabIndex = 4;
            this.productCombobox.SelectedValueChanged += new System.EventHandler(this.productCombobox_SelectedValueChanged);
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
            // saleDataGridView
            // 
            this.saleDataGridView.AllowUserToAddRows = false;
            this.saleDataGridView.AllowUserToDeleteRows = false;
            this.saleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.saleDataGridView.Location = new System.Drawing.Point(35, 165);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.ReadOnly = true;
            this.saleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleDataGridView.Size = new System.Drawing.Size(480, 150);
            this.saleDataGridView.TabIndex = 10;
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
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
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
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
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
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.YellowGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(472, 362);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 29);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // customerNameCombobox
            // 
            this.customerNameCombobox.FormattingEnabled = true;
            this.customerNameCombobox.Location = new System.Drawing.Point(158, 29);
            this.customerNameCombobox.Name = "customerNameCombobox";
            this.customerNameCombobox.Size = new System.Drawing.Size(200, 29);
            this.customerNameCombobox.TabIndex = 20;
            this.customerNameCombobox.SelectedValueChanged += new System.EventHandler(this.customerNameCombobox_SelectedValueChanged);
            // 
            // customerPhoneCombobox
            // 
            this.customerPhoneCombobox.FormattingEnabled = true;
            this.customerPhoneCombobox.Location = new System.Drawing.Point(158, 71);
            this.customerPhoneCombobox.Name = "customerPhoneCombobox";
            this.customerPhoneCombobox.Size = new System.Drawing.Size(200, 29);
            this.customerPhoneCombobox.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ManagerSaleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.customerPhoneCombobox);
            this.Controls.Add(this.customerNameCombobox);
            this.Controls.Add(this.paymentTextbox);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceTextbox);
            this.Controls.Add(this.saleDataGridView);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productCombobox);
            this.Controls.Add(this.customerPhoneLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerSaleUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.ComboBox productCombobox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.DataGridView saleDataGridView;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalPriceTextbox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox paymentTextbox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.ComboBox customerNameCombobox;
        private System.Windows.Forms.ComboBox customerPhoneCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
