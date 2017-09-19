﻿namespace CafeApp
{
    partial class BookForm
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
            this.labelCafe = new System.Windows.Forms.Label();
            this.listViewCafe = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCafe
            // 
            this.labelCafe.AutoSize = true;
            this.labelCafe.Location = new System.Drawing.Point(10, 21);
            this.labelCafe.Name = "labelCafe";
            this.labelCafe.Size = new System.Drawing.Size(37, 17);
            this.labelCafe.TabIndex = 0;
            this.labelCafe.Text = "Cafe";
            this.labelCafe.Click += new System.EventHandler(this.label1_Click);
            // 
            // listViewCafe
            // 
            this.listViewCafe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAddress,
            this.columnPhoneNumber});
            this.listViewCafe.Location = new System.Drawing.Point(13, 291);
            this.listViewCafe.Name = "listViewCafe";
            this.listViewCafe.Size = new System.Drawing.Size(1034, 276);
            this.listViewCafe.TabIndex = 2;
            this.listViewCafe.UseCompatibleStateImageBehavior = false;
            this.listViewCafe.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 118;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 158;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "PhoneNumber";
            this.columnPhoneNumber.Width = 179;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 209);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 737);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listViewCafe);
            this.Controls.Add(this.labelCafe);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCafe;
        private System.Windows.Forms.ListView listViewCafe;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}