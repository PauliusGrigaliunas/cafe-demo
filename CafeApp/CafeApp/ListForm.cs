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
        SqlConnection connection = new SqlConnection("Server=tcp:cafeappdb.database.windows.net,1433;Initial Catalog=CafeAppDB;Persist Security Info=False;User ID=admincontrol34;Password=Admincontrol7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlDataReader dr;

        public int id;
        string email;
        public ListForm(string email)
        {
            this.email = email;
            InitializeComponent();

            listViewCafe.View = View.Details; //ability to select row
            listViewCafe.FullRowSelect = true; //ability to select row

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

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Restaurants";
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
                        item.SubItems.Add(dr["Tables"].ToString());
                        item.SubItems.Add(dr["Phone"].ToString());
                        item.SubItems.Add(dr["Email"].ToString());

                        item.SubItems.Add(dr["Workdays"].ToString());
                        item.SubItems.Add(dr["Saturday"].ToString());
                        item.SubItems.Add(dr["Sunday"].ToString());
                        listViewCafe.Items.Add(item);
                    }

                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void listViewCafe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String idString = listViewCafe.SelectedItems[0].Text;  //id (String)
                id = Convert.ToInt32(idString); // idInt (int) turėtų sutapt su Id iš duomenų bazės
                CafeDataForm cafe = new CafeDataForm(id, email);

                cafe.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Pasirinkite restoraną ar kavinę!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Restaurants";

            listViewCafe.Items.Clear();
            {
                try
                {
                    connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {

                        if (dr["Name"].ToString() == textBox1.Text || textBox1.Text == String.Empty)
                        {
                            ListViewItem item = new ListViewItem(dr["Id"].ToString());
                            item.SubItems.Add(dr["Name"].ToString());
                            item.SubItems.Add(dr["Address"].ToString());
                            item.SubItems.Add(dr["Tables"].ToString());
                            item.SubItems.Add(dr["Phone"].ToString());
                            item.SubItems.Add(dr["Email"].ToString());

                            item.SubItems.Add(dr["Workdays"].ToString());
                            item.SubItems.Add(dr["Saturday"].ToString());
                            item.SubItems.Add(dr["Sunday"].ToString());
                            listViewCafe.Items.Add(item);
                        }
                    }

                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}


