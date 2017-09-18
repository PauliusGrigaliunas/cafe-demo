﻿namespace CafeApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CupOfCafe = new System.Windows.Forms.PictureBox();
            this.Register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CupOfCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "El. paštas:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(70, 296);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(64, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Slaptažodis:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(153, 263);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(196, 20);
            this.Email.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CupOfCafe
            // 
            this.CupOfCafe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CupOfCafe.BackgroundImage")));
            this.CupOfCafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CupOfCafe.Location = new System.Drawing.Point(54, 12);
            this.CupOfCafe.Name = "CupOfCafe";
            this.CupOfCafe.Size = new System.Drawing.Size(295, 222);
            this.CupOfCafe.TabIndex = 5;
            this.CupOfCafe.TabStop = false;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(106, 328);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(86, 30);
            this.Register.TabIndex = 6;
            this.Register.Text = "Registruotis";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(415, 383);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.CupOfCafe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.CupOfCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox CupOfCafe;
        private System.Windows.Forms.Button Register;
    }
}