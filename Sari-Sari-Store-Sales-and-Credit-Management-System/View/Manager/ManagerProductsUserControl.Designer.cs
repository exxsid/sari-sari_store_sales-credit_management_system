namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    partial class ManagerProductsUserControl
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
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.addProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(24, 53);
            this.productsDataGrid.MultiSelect = false;
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.Size = new System.Drawing.Size(620, 267);
            this.productsDataGrid.TabIndex = 0;
            // 
            // addProductButton
            // 
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(24, 344);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 30);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "New";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // updateProductButton
            // 
            this.updateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProductButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductButton.Location = new System.Drawing.Point(105, 344);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(75, 30);
            this.updateProductButton.TabIndex = 2;
            this.updateProductButton.Text = "Update";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.BackColor = System.Drawing.Color.Red;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusButton.Location = new System.Drawing.Point(512, 344);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(132, 30);
            this.changeStatusButton.TabIndex = 3;
            this.changeStatusButton.Text = "Change Status";
            this.changeStatusButton.UseVisualStyleBackColor = false;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(569, 19);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 30);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(488, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(24, 21);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(447, 24);
            this.searchBar.TabIndex = 10;
            // 
            // ManagerProductsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.changeStatusButton);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productsDataGrid);
            this.Name = "ManagerProductsUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            this.Load += new System.EventHandler(this.ManagerProductsUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.ManagerProductsUserControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
    }
}
