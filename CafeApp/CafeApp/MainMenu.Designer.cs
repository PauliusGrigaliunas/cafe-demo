namespace CafeApp
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddCafe = new System.Windows.Forms.Button();
            this.SearchCafes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EmailLabel.Location = new System.Drawing.Point(228, 13);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(136, 20);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "emailas zmogaus!";
            // 
            // AddCafe
            // 
            this.AddCafe.Location = new System.Drawing.Point(24, 70);
            this.AddCafe.Name = "AddCafe";
            this.AddCafe.Size = new System.Drawing.Size(101, 34);
            this.AddCafe.TabIndex = 2;
            this.AddCafe.Text = "Add a Cafe";
            this.AddCafe.UseVisualStyleBackColor = true;
            this.AddCafe.Click += new System.EventHandler(this.AddCafe_Click);
            // 
            // SearchCafes
            // 
            this.SearchCafes.Location = new System.Drawing.Point(141, 70);
            this.SearchCafes.Name = "SearchCafes";
            this.SearchCafes.Size = new System.Drawing.Size(99, 34);
            this.SearchCafes.TabIndex = 3;
            this.SearchCafes.Text = "Search Cafes";
            this.SearchCafes.UseVisualStyleBackColor = true;
            this.SearchCafes.Click += new System.EventHandler(this.SearchCafes_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(213, 272);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(87, 35);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(510, 378);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchCafes);
            this.Controls.Add(this.AddCafe);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button AddCafe;
        private System.Windows.Forms.Button SearchCafes;
        private System.Windows.Forms.Button Exit;
    }
}