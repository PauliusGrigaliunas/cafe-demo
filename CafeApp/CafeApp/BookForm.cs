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
        SqlConnection connection; // Connection to database
        SqlDataReader dr;

        public String id;

        public BookForm()
        {
            InitializeComponent();

            listViewCafe.View = View.Details; //ability to select row
            listViewCafe.FullRowSelect = true; //ability to select row

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
            using (SqlCommand command = new SqlCommand("SELECT * FROM CaffeTable", connection))
            {
                try
                {
                    connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["Id"].ToString()); 
                        item.SubItems.Add(dr["Name"].ToString());
                        item.SubItems.Add(dr["Address"].ToString());
                        item.SubItems.Add(dr["Phone Number"].ToString());
                        item.SubItems.Add(dr["Email"].ToString());
                        item.SubItems.Add(dr["Free tables"].ToString());
                        item.SubItems.Add(dr["All tables"].ToString());
                        item.SubItems.Add(dr["Rating"].ToString());
                        item.SubItems.Add(dr["Comments"].ToString());
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
            //var num = listViewCafe.SelectedIndices;           
            //MessageBox.Show(listViewCafe.SelectedItems.Text);
            id = listViewCafe.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(id);

        }
    }
}
