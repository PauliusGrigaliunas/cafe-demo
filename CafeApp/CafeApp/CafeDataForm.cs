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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\cafe-demo\CafeApp\CafeApp\Database1.mdf;Integrated Security=True");

        public CafeDataForm(int id)
        {
            this.id = id;
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
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            int tables = int.Parse(textBox3.Text);
            try
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Restaurants SET Name='"+name+"',Address='"+address+"',Tables='"+tables+"' WHERE ID='"+id+"'";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Changed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

















// Karolio chuj znaet kas :D prispaudinejo turbut

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafeDataForm_Load(object sender, EventArgs e)
        {
            
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
