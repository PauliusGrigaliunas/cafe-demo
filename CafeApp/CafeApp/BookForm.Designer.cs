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
            this.listCafe = new System.Windows.Forms.ListBox();
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
            // listCafe
            // 
            this.listCafe.FormattingEnabled = true;
            this.listCafe.ItemHeight = 16;
            this.listCafe.Location = new System.Drawing.Point(12, 60);
            this.listCafe.Name = "listCafe";
            this.listCafe.Size = new System.Drawing.Size(496, 404);
            this.listCafe.TabIndex = 1;
            this.listCafe.SelectedIndexChanged += new System.EventHandler(this.listCafe_SelectedIndexChanged);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 496);
            this.Controls.Add(this.listCafe);
            this.Controls.Add(this.labelCafe);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCafe;
        private System.Windows.Forms.ListBox listCafe;
    }
}