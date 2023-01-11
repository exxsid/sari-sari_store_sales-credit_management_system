namespace Sari_Sari_Store_Sales_and_Credit_Management_System.View.Manager
{
    partial class ManagerUsersUserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(602, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // addUserButton
            // 
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Location = new System.Drawing.Point(33, 346);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(87, 32);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // updateUserButton
            // 
            this.updateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUserButton.Location = new System.Drawing.Point(136, 346);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(87, 32);
            this.updateUserButton.TabIndex = 2;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.Red;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Location = new System.Drawing.Point(548, 346);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(87, 32);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            // 
            // ManagerUsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerUsersUserControl";
            this.Size = new System.Drawing.Size(675, 403);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button deleteUserButton;
    }
}
