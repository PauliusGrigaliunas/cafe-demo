namespace CafeApp
{
    partial class Booking
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bookTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurantName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // bookTable
            // 
            this.bookTable.Location = new System.Drawing.Point(145, 275);
            this.bookTable.Name = "bookTable";
            this.bookTable.Size = new System.Drawing.Size(131, 37);
            this.bookTable.TabIndex = 2;
            this.bookTable.Text = "Book a table!";
            this.bookTable.UseVisualStyleBackColor = true;
            this.bookTable.Click += new System.EventHandler(this.bookTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restaurant:";
            // 
            // restaurantName
            // 
            this.restaurantName.AutoSize = true;
            this.restaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.restaurantName.Location = new System.Drawing.Point(191, 25);
            this.restaurantName.Name = "restaurantName";
            this.restaurantName.Size = new System.Drawing.Size(0, 17);
            this.restaurantName.TabIndex = 4;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(437, 368);
            this.Controls.Add(this.restaurantName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookTable);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bookTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label restaurantName;
    }
}