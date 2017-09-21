﻿using System;
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
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Albert\Documents\GitHub\cafe-demo\CafeApp\CafeApp\Database1.mdf;Integrated Security=True");

        SqlDataReader dr;

        public int id;

        public ListForm()
        {
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

            // Karoliui!
            String idString = listViewCafe.SelectedItems[0].Text;  //id (String)
            id = Convert.ToInt32(idString); // idInt (int) turėtų sutapt su Id iš duomenų bazės
            CafeDataForm cafe = new CafeDataForm(id);
            cafe.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


