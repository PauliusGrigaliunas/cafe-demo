using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CafeApp
{
    public partial class RegisterWindow : Form
    {

        public string name;
        public string surname;
        public string e_mail;  // NOTE: Email = username
        public string password;

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            surname = textBox2.Text;
            e_mail = textBox3.Text;
            password = textBox4.Text;
            /// TODO: Validation system (check for valid email, password. 
            /// After validating data INSTERT TO DB
            /// Note: Don't forget about try/catch 
        }
    }
}
