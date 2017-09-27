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

        private void Booking_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Width = 100;
            this.dateTimePicker1.ShowUpDown = true;
            label4.Text = null;
            label5.Text = null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = dateTimePicker1.Value.ToShortTimeString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = dateTimePicker2.Value.ToShortDateString();
        }
    }
}
