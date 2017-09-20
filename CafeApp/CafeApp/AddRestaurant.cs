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
        static int id = 0;
        public bool inserted = false;

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paulius\Documents\GitHub\cafe-demo\CafeApp\CafeApp\Database1.mdf;Integrated Security=True");

        public AddRestaurant()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            name = NameBox.Text;
            address = AddressBox.Text;
            phone = PhoneBox.Text;
            tables = int.Parse(TablesBox.Text);
            workdays = WorkdaysBox.Text;
            saturday = SaturdayBox.Text;
            sunday = SundayBox.Text;



            try
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Restaurants";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if ( !CheckIfNameExists(dt, NameBox.Text) && !inserted )
                {
                    cmd.CommandText = "INSERT INTO Restaurants (ID,Name,Address,Tables,Phone,Workdays,Saturday,Sunday) VALUES('"+id+"','"+name+"','"+address+"','"+tables+"','"+phone+"','"+workdays+"','"+saturday+"','"+sunday+"')";
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
            this.Close();
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
    }
}
