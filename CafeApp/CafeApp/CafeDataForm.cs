using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeApp
{
    public partial class CafeDataForm : Form
    {
        public int id;
        SqlConnection connect = new SqlConnection("Server = tcp:covfefedb.database.windows.net, 1433; Initial Catalog = covfefe; Persist Security Info=False;User ID = { your_username }; Password={your_password}; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

        string checkingEmail;
        string email;
        public CafeDataForm(int id, string email)
        {
            this.id = id;
            this.email = email;
            InitializeComponent();
            ShowInfo(id);
        }
        private void ShowInfo(int id)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Restaurants WHERE ID='"+id+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                searchCodeBox.Text = dt.Rows[0][0].ToString();
                name.Text = dt.Rows[0][1].ToString();
                address.Text = dt.Rows[0][2].ToString();
                label11.Text = dt.Rows[0][3].ToString();
                number.Text = dt.Rows[0][4].ToString();
                checkingEmail = dt.Rows[0][8].ToString();
                connect.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void ChangeCafe_Click(object sender, EventArgs e)
        {
            if (checkingEmail == email)
            {
                string name = textBox1.Text;
                string address = textBox2.Text;
                int tables;
                string phone = textBox4.Text;
                try
                {
                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cmd.CommandText = "UPDATE Restaurants SET Name='" + name + "' WHERE ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(textBox2.Text))
                    {
                        cmd.CommandText = "UPDATE Restaurants SET Address='" + address + "' WHERE ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(textBox3.Text))
                    {
                        tables = int.Parse(textBox3.Text);
                        cmd.CommandText = "UPDATE Restaurants SET Tables='" + tables + "' WHERE ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(textBox4.Text))
                    {
                        cmd.CommandText = "UPDATE Restaurants SET Phone='" + phone + "' WHERE ID='" + id + "'";
                        cmd.ExecuteNonQuery();
                    }
                    connect.Close();
                    MessageBox.Show("Changed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sorry, but only creator has access to change data");
            }

            this.Close();
        }
    }
}
