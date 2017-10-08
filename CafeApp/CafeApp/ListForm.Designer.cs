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
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWorkdays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSaturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSunday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.searchByLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCafe
            // 
            this.listViewCafe.BackColor = System.Drawing.SystemColors.Info;
            this.listViewCafe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnAddress,
            this.columnTable,
            this.columnPhone,
            this.columnEmail,
            this.columnWorkdays,
            this.columnSaturday,
            this.columnSunday});
            this.listViewCafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.listViewCafe.Location = new System.Drawing.Point(0, 0);
            this.listViewCafe.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCafe.Name = "listViewCafe";
            this.listViewCafe.Size = new System.Drawing.Size(946, 379);
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
            this.columnName.Width = 150;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 200;
            // 
            // columnTable
            // 
            this.columnTable.Text = "Table";
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone number";
            this.columnPhone.Width = 150;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 150;
            // 
            // columnWorkdays
            // 
            this.columnWorkdays.Text = "Workdays";
            this.columnWorkdays.Width = 100;
            // 
            // columnSaturday
            // 
            this.columnSaturday.Text = "Saturday";
            this.columnSaturday.Width = 100;
            // 
            // columnSunday
            // 
            this.columnSunday.Text = "Sunday";
            this.columnSunday.Width = 100;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(713, 405);
            this.infoButton.Margin = new System.Windows.Forms.Padding(2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(193, 42);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "Show Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(47, 405);
            this.bookButton.Name = "bookButton";
            this.bookButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookButton.Size = new System.Drawing.Size(212, 42);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book A Table";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(301, 405);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(166, 20);
            this.searchBox.TabIndex = 3;
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(482, 405);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(192, 24);
            this.searchByNameButton.TabIndex = 4;
            this.searchByNameButton.Text = "Search by Name";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchByLocationButton
            // 
            this.searchByLocationButton.Location = new System.Drawing.Point(481, 437);
            this.searchByLocationButton.Name = "searchByLocationButton";
            this.searchByLocationButton.Size = new System.Drawing.Size(193, 21);
            this.searchByLocationButton.TabIndex = 5;
            this.searchByLocationButton.Text = "Search by Location";
            this.searchByLocationButton.UseVisualStyleBackColor = true;
            this.searchByLocationButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 470);
            this.Controls.Add(this.searchByLocationButton);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.listViewCafe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.Activated += new System.EventHandler(this.ListForm_Activated);
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCafe;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnTable;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnWorkdays;
        private System.Windows.Forms.ColumnHeader columnSaturday;
        private System.Windows.Forms.ColumnHeader columnSunday;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Button searchByLocationButton;
    }
}