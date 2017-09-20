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
    public partial class ListForm : Form
    {
        String ConnectionString; // String to reach database
        SqlConnection connection; // Connection to database
        SqlDataReader dr;

        public int id;

        public ListForm()
        {
            InitializeComponent();

            listViewCafe.View = View.Details; //ability to select row
            listViewCafe.FullRowSelect = true; //ability to select row

            ConnectionString = ConfigurationManager.ConnectionStrings["CafeApp.Properties.Settings.BookDatabaseConnectionString"].ConnectionString;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ListForm_Load(object sender, EventArgs e)
        {
            populateCafe();
        }

        private void populateCafe()
        {

            
            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Restaurants", connection))
            {
                try
                {
                    connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["Id"].ToString());
                        item.SubItems.Add(dr["Name"].ToString());

                        listViewCafe.Items.Add(item);
                    }

                    connection.Close();
                }

                catch (Exception ex)
                {
                }

            }
        }

        private void listViewCafe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Karoliui!
            String idString = listViewCafe.SelectedItems[0].Text;  //id (String)
            MessageBox.Show(idString);
            id = Convert.ToInt32(idString); // idInt (int) turėtų sutapt su Id iš duomenų bazės

        }
    }
}


