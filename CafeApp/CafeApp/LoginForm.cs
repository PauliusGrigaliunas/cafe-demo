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
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Integrated Security = true;AttachDbFilename = C:\\Users\\Mode\\Documents\\GitHub\\cafe-demo\\cafe-demo\\CafeApp\\CafeApp\\bin\\Debug\\Database1.mdf;");
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        string msg;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();                                                //prisijungiam prie db
                SqlCommand cmd = connect.CreateCommand();                      // sukuriam komanda
                cmd.CommandType = CommandType.Text;                             //nustatom komanda teksto tipo
                cmd.CommandText = "SELECT * FROM Users WHERE Email='"+Email.Text+"'AND Password='"+textBox2.Text+"'";                        // parenkam visa lentele 
                cmd.ExecuteNonQuery();                                           //vykdom komandine cmd eilute
                DataTable dt = new DataTable();                                //sukuriam saugojimui duomenu lentele
                SqlDataAdapter da = new SqlDataAdapter(cmd);                   //sukuriam sql duomenu adapteri, kurie jau yra isspausdinti cmd                           
                da.Fill(dt);                                                //uzpildom duomenu lentele dt
                int i = dt.Rows.Count;                                          //surandame ar yra nors viena eilute su tokiais duomenim
                if ( i == 1 )                                             //jei yra 1, tada cool, prisijungta sekminga
                {
                    msg = "Sveiki prisijungę kaip " + Email.Text;
                    MessageBox.Show(msg);
                }
                else
                {
                    Email.Text = null;
                    textBox2.Text = null;
                    MessageBox.Show("Atsiprašome, bet el. pašto adresas arba slaptažodis neteisingi!");
                }
                connect.Close();                                               //atsijungiam nuo db
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterWindow reg = new RegisterWindow();
            reg.ShowDialog();

        }
    }
}
