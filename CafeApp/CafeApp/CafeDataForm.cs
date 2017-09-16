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
    public partial class CafeDataForm : Form
    {
        public CafeDataForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create cafe object
            int tableInt = Int32.Parse(textBox3.Text);
            Kavine testCafe = new Kavine(textBox1.Text, textBox2.Text, tableInt);

            name.Text = testCafe._name;
            address.Text = testCafe._address;
            searchCodeBox.Text = testCafe._searchCode;
            number.Text = testCafe._phoneNumber;
            label11.Text = testCafe._tableCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Push cafe object to DB
            PushLabel.Text = "Pushed to SQL";
            //TODO actual pushing into SQL
        }

        private void CafeDataForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
