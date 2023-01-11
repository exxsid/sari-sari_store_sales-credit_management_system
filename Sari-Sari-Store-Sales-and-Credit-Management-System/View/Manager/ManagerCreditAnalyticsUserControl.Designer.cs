namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    partial class ManagerCreditAnalyticsUserControl
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
            this.creditAnalyticsDatagridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.creditAnalyticsDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // creditAnalyticsDatagridView
            // 
            this.creditAnalyticsDatagridView.AllowUserToAddRows = false;
            this.creditAnalyticsDatagridView.AllowUserToDeleteRows = false;
            this.creditAnalyticsDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditAnalyticsDatagridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creditAnalyticsDatagridView.Location = new System.Drawing.Point(0, 73);
            this.creditAnalyticsDatagridView.Name = "creditAnalyticsDatagridView";
            this.creditAnalyticsDatagridView.ReadOnly = true;
            this.creditAnalyticsDatagridView.Size = new System.Drawing.Size(675, 330);
            this.creditAnalyticsDatagridView.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(573, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(27, 23);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(526, 24);
            this.searchBar.TabIndex = 8;
            // 
            // ManagerCreditAnalyticsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.creditAnalyticsDatagridView);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerCreditAnalyticsUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            ((System.ComponentModel.ISupportInitialize)(this.creditAnalyticsDatagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView creditAnalyticsDatagridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
    }
}
