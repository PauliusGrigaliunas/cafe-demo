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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void bookTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
