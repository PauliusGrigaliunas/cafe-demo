﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class MainMenu : Form
    {
        public string email;
        private Form _loginForm;

        public MainMenu(string email, Form loginForm)
        {
            this.email = email;
            InitializeComponent();
            EmailLabel.Text = email + "!";
            _loginForm = loginForm; //Needed in order to get back to hidden login form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRestaurantForm add = new AddRestaurantForm(email);
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(email);
            listForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        protected override void OnFormClosing(FormClosingEventArgs e) //On closed MainMenu reveals hidden LoginForm
        {
            _loginForm.Show();
        }
    }
}
