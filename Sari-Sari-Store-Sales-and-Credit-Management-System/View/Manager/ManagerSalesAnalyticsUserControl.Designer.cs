namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    partial class ManagerSalesAnalyticsUserControl
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
            this.salesAnalyticsDatagridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalSaleDisplay = new System.Windows.Forms.Label();
            this.comparisonDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.topSellingDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesAnalyticsDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSellingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesAnalyticsDatagridView
            // 
            this.salesAnalyticsDatagridView.AllowUserToAddRows = false;
            this.salesAnalyticsDatagridView.AllowUserToDeleteRows = false;
            this.salesAnalyticsDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.salesAnalyticsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesAnalyticsDatagridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.salesAnalyticsDatagridView.Location = new System.Drawing.Point(317, 0);
            this.salesAnalyticsDatagridView.Name = "salesAnalyticsDatagridView";
            this.salesAnalyticsDatagridView.ReadOnly = true;
            this.salesAnalyticsDatagridView.Size = new System.Drawing.Size(358, 403);
            this.salesAnalyticsDatagridView.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MMMM yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(22, 13);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(192, 25);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2023, 1, 17, 0, 0, 0, 0);
            // 
            // loadButton
            // 
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Location = new System.Drawing.Point(220, 13);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 28);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Sales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comparision to last month sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Top-selling products";
            // 
            // totalSaleDisplay
            // 
            this.totalSaleDisplay.AutoSize = true;
            this.totalSaleDisplay.Location = new System.Drawing.Point(59, 89);
            this.totalSaleDisplay.Name = "totalSaleDisplay";
            this.totalSaleDisplay.Size = new System.Drawing.Size(53, 20);
            this.totalSaleDisplay.TabIndex = 8;
            this.totalSaleDisplay.Text = "P 0.00";
            // 
            // comparisonDisplay
            // 
            this.comparisonDisplay.AutoSize = true;
            this.comparisonDisplay.Location = new System.Drawing.Point(231, 160);
            this.comparisonDisplay.Name = "comparisonDisplay";
            this.comparisonDisplay.Size = new System.Drawing.Size(48, 20);
            this.comparisonDisplay.TabIndex = 9;
            this.comparisonDisplay.Text = "100%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Sales increased by";
            // 
            // topSellingDataGridView
            // 
            this.topSellingDataGridView.AllowUserToAddRows = false;
            this.topSellingDataGridView.AllowUserToDeleteRows = false;
            this.topSellingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.topSellingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topSellingDataGridView.Location = new System.Drawing.Point(63, 231);
            this.topSellingDataGridView.Name = "topSellingDataGridView";
            this.topSellingDataGridView.ReadOnly = true;
            this.topSellingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.topSellingDataGridView.Size = new System.Drawing.Size(240, 150);
            this.topSellingDataGridView.TabIndex = 11;
            // 
            // ManagerSalesAnalyticsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.topSellingDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comparisonDisplay);
            this.Controls.Add(this.totalSaleDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.salesAnalyticsDatagridView);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerSalesAnalyticsUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            ((System.ComponentModel.ISupportInitialize)(this.salesAnalyticsDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSellingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesAnalyticsDatagridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalSaleDisplay;
        private System.Windows.Forms.Label comparisonDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView topSellingDataGridView;
    }
}
