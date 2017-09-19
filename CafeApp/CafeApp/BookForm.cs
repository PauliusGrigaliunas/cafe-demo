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
            populateCafe();
        }

        private void populateCafe() {

            using (connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CaffeTable", connection)) {


                DataTable cafeTable = new DataTable();
                adapter.Fill(cafeTable);

                dataGridView1.DataSource = cafeTable;
                

                //
                //SqlDataReader dr = 

                //listCafe.DisplayMember = "Name";
                //listCafe.ValueMember = "Email";
                //listCafe.DataSource = cafeTable;


            }

                    


        }

        private void listCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listCafe.SelectedValue.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
