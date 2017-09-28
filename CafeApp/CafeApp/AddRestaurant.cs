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
    public partial class AddRestaurant : Form
    {
        string name;
        string address;
        string phone;
        int tables;
        string workdays;
        string saturday;
        string sunday;
        private int id;
        public bool inserted = false;
        string email;

        SqlConnection connect = new SqlConnection("Server=tcp:cafeappdb.database.windows.net,1433;Initial Catalog=CafeAppDB;Persist Security Info=False;User ID=admincontrol34;Password=Admincontrol7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");



        public AddRestaurant( string email )
        {
            this.email = email;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool mandatoryFieldsEmpty = false;

            //Mandatory to fill: name, address (,tables)
            name = NameBox.Text;
            address = AddressBox.Text;
            phone = PhoneBox.Text;
            tables = (int)TablesBox.Value;
            workdays = WorkdaysBox.Text;
            saturday = SaturdayBox.Text;
            sunday = SundayBox.Text;

            //---String checking/fixing
            if (name.Length == 0 || address.Length == 0)
                mandatoryFieldsEmpty = true;

            //Should add ALL of the strings passed to DB just to be safe
            name = name.Replace("'", "''");
            address = address.Replace("'", "''");
            phone = phone.Replace("'", "''");
            //---

            if (mandatoryFieldsEmpty)
                MessageBox.Show("You forgot to fill some mandatory information. Try again");
            else try
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Restaurants";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                id = dt.Rows.Count;
                id++;
                if ( !CheckIfNameExists(dt, NameBox.Text) && !inserted )
                {
                    cmd.CommandText = "INSERT INTO Restaurants (ID,Name,Address,Tables,Phone,Workdays,Saturday,Sunday,Email) VALUES('"+id+"','"+name+"','"+address+"','"+tables+"','"+phone+"','"+workdays+"','"+saturday+"','"+sunday+"','"+email+"')";
                    cmd.ExecuteNonQuery();
                    inserted = true;
                    MessageBox.Show("Restaurant successfully added!");
                    id++;
                }
                else
                {
                    MessageBox.Show("Restaurant with this name already exists, please check again.");
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }

            //this.Close(); //Removed for design reasons. I don't think "Add" button should have Exit functionality (K.S.)
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

        private void AddRestaurant_Load(object sender, EventArgs e)
        {

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
