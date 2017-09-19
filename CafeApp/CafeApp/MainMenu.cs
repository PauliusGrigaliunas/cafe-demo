using System;
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
        private string email;

        public MainMenu(string email)
        {
            this.email = email;
            InitializeComponent();
            EmailLabel.Text = email + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
