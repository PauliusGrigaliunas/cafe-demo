namespace CafeApp
{
    partial class ListForm
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
            this.listViewCafe = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCafe
            // 
            this.listViewCafe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName});
            this.listViewCafe.Location = new System.Drawing.Point(9, 10);
            this.listViewCafe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewCafe.Name = "listViewCafe";
            this.listViewCafe.Size = new System.Drawing.Size(895, 369);
            this.listViewCafe.TabIndex = 0;
            this.listViewCafe.UseCompatibleStateImageBehavior = false;
            this.listViewCafe.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "Id";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewCafe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCafe;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}