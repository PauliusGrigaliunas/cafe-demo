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
            AddRestaurant add = new AddRestaurant();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();
            listForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
