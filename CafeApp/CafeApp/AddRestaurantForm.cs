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
    public partial class AddRestaurantForm : Form
    {

        Connector connector = new Connector();
        SqlConnection connect;

        int id;
        string name;
        string address;
        string phone;
        int tables;
        string workdays;
        string saturday;
        string sunday;
        string restaurantsEmail;    //<--- viesas pastas matomas klientams
        string registerActorsEmail; //<--- prisijungusio registruotojo pastas

        bool inserted;

        public SqlConnection Connect { get => connect; set => connect = value; }

        public AddRestaurantForm(string userEmail)
        {
            connect = new SqlConnection (connector.ConnectionString);
            registerActorsEmail = userEmail;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Mandatory to fill: name, address
            name = NameBox.Text;
            address = AddressBox.Text;
            if (name.Length == 0 || address.Length == 0)
                MessageBox.Show("You forgot to fill some mandatory information. Try again");
            else
            {
                phone = PhoneBox.Text;
                tables = (int)TablesBox.Value;
                workdays = WorkdaysBox.Text;
                saturday = SaturdayBox.Text;
                sunday = SundayBox.Text;

                //NOTE: Should add ALL of the string variables passed to DB
                name = name.Replace("'", "''");
                address = address.Replace("'", "''");
                phone = phone.Replace("'", "''");

                try
                {
                    Connect.Open();
                    SqlCommand cmd = Connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Cafes";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    id = dt.Rows.Count;
                    id++;
                    if (!CheckIfNameExists(dt, NameBox.Text) && !inserted)
                    {
                        cmd.CommandText = "INSERT INTO Cafes (ID,Name,Address,Tables,Phone,Workdays,Saturday,Sunday,Email) VALUES('" + id + "','" + name + "','" + address + "','" + tables + "','" + phone + "','" + workdays + "','" + saturday + "','" + sunday + "','" + registerActorsEmail + "')";
                        cmd.ExecuteNonQuery();

                        //+
                        for ( int i = 1; i <= tables ; i++) { 
                        cmd.CommandText = "INSERT INTO CafeTable(Cafe,Nr) VALUES('" + id + "','" + i + "')";
                            cmd.ExecuteNonQuery();
                        }
                        
                        //-

                        inserted = true;
                        MessageBox.Show("Cafe successfully added!");
                        id++;
                    }
                    else
                    {
                        MessageBox.Show("Cafe with this name already exists, please try again.");
                    }
                    Connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connect.Close();
                }
            }

        }

        private bool CheckIfNameExists(DataTable dt, string data)
        {
            bool exist = false;
            for ( int i = 0; i < dt.Rows.Count; i++)
            {
                if ( data == dt.Rows[i][1].ToString())
                {
                    exist = true;
                }
            }
            return exist;
        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddressBox.Focus();

            }
        }

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TablesBox.Focus();

            }

        }

        private void TablesBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PhoneBox.Focus();

            }
        }

        private void PhoneBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WorkdaysBox.Focus();

            }
        }

        private void WorkdaysBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaturdayBox.Focus();

            }
        }

        private void SaturdayBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SundayBox.Focus();

            }
        }

        private void SundayBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton.PerformClick();

            }
        }
    }
}
