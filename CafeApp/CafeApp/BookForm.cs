using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CafeApp
{
    public partial class BookForm : Form
    {
        String ConnectionString; // String to reach database
        SqlConnection connection; //

        public BookForm()
        {
            InitializeComponent();

            ConnectionString = ConfigurationManager.ConnectionStrings["CafeApp.Properties.Settings.BookDatabaseConnectionString"].ConnectionString;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void populateCafe() {

            connection = new SqlConnection(ConnectionString);
            connection.Open();


            connection.Close();

        }
    }
}
