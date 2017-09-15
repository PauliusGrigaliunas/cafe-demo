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
        public string e_mail;
        public string password;

       // private static string pathToFile = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\cafe-demo\CafeApp\CafeApp\register.txt";
    
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
        }
    }
}
