namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager.ProductForms
{
    partial class UpdateProductForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.wholesalePriceTextbox = new System.Windows.Forms.TextBox();
            this.wholesalePriceLabel = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.typeUpdateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Location = new System.Drawing.Point(99, 359);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 31);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(318, 359);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 31);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // wholesalePriceTextbox
            // 
            this.wholesalePriceTextbox.Location = new System.Drawing.Point(99, 235);
            this.wholesalePriceTextbox.Name = "wholesalePriceTextbox";
            this.wholesalePriceTextbox.Size = new System.Drawing.Size(294, 22);
            this.wholesalePriceTextbox.TabIndex = 17;
            // 
            // wholesalePriceLabel
            // 
            this.wholesalePriceLabel.AutoSize = true;
            this.wholesalePriceLabel.Location = new System.Drawing.Point(96, 219);
            this.wholesalePriceLabel.Name = "wholesalePriceLabel";
            this.wholesalePriceLabel.Size = new System.Drawing.Size(106, 16);
            this.wholesalePriceLabel.TabIndex = 16;
            this.wholesalePriceLabel.Text = "Wholesale Price";
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(99, 168);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(294, 22);
            this.priceTextbox.TabIndex = 15;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(96, 152);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(76, 16);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Retail Price";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(99, 101);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(294, 22);
            this.quantityTextbox.TabIndex = 13;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(96, 85);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(55, 16);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.Text = "Quantity";
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Location = new System.Drawing.Point(99, 34);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(294, 22);
            this.productNameTextbox.TabIndex = 11;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(96, 15);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(93, 16);
            this.productNameLabel.TabIndex = 10;
            this.productNameLabel.Text = "Product Name";
            // 
            // typeCombobox
            // 
            this.typeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "Purchase",
            "Destroyed"});
            this.typeCombobox.Location = new System.Drawing.Point(99, 302);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(294, 24);
            this.typeCombobox.TabIndex = 20;
            // 
            // typeUpdateLabel
            // 
            this.typeUpdateLabel.AutoSize = true;
            this.typeUpdateLabel.Location = new System.Drawing.Point(96, 286);
            this.typeUpdateLabel.Name = "typeUpdateLabel";
            this.typeUpdateLabel.Size = new System.Drawing.Size(39, 16);
            this.typeUpdateLabel.TabIndex = 21;
            this.typeUpdateLabel.Text = "Type";
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 402);
            this.Controls.Add(this.typeUpdateLabel);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.wholesalePriceTextbox);
            this.Controls.Add(this.wholesalePriceLabel);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.productNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox wholesalePriceTextbox;
        private System.Windows.Forms.Label wholesalePriceLabel;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.Label typeUpdateLabel;
    }
}