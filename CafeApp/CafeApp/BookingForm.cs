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
    public partial class BookingForm : Form
    {
        DateTime now;
        DateTime selectedDate;
        DateTime selectedTime;
        TimeSpan t;
        public BookingForm()
        {
            InitializeComponent();
        }

        private void bookTable_Click(object sender, EventArgs e)
        {
            DateTime newDate = selectedDate.
                AddHours(-selectedDate.Hour).                     //nunulinam selected date reiksme, jei dar yra kazkas daugiau uz 0
                AddMinutes(-selectedDate.Minute).
                AddSeconds(-selectedDate.Second).
                AddHours(selectedTime.Hour).                          //pridedam pasirinkta reiksme
                AddMinutes(selectedTime.Minute);
            //ta new date jau gali naudot kaip rezervavimo laika. 
            DateTime now = DateTime.Now;
            t = newDate - now;
            label6.Text = t.TotalDays.ToString();
            if ( t.TotalDays < 0)
            {
                MessageBox.Show("Selected date has already passed! Please select another");
            }
            else MessageBox.Show("Booking successful! Enjoy your meal :)");
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Width = 100;
            this.dateTimePicker1.ShowUpDown = true;
            label4.Text = null;
            label5.Text = null;
            now = DateTime.Now;
            selectedTime = dateTimePicker1.Value;
            selectedDate = dateTimePicker2.Value;
            label4.Text = dateTimePicker2.Value.ToShortDateString();
            label5.Text = dateTimePicker1.Value.ToShortTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            selectedTime = dateTimePicker1.Value;
            label5.Text = dateTimePicker1.Value.ToShortTimeString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dateTimePicker2.Value;
            label4.Text = dateTimePicker2.Value.ToShortDateString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
