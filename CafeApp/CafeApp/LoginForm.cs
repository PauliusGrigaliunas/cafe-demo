﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Backend;

namespace CafeApp
{
    public partial class LoginForm : Form
    {
        AccountOperations AccOps = new AccountOperations();

        SqlConnection connect = new SqlConnection("Server=tcp:covfefedb.database.windows.net,1433;Initial Catalog=covfefe;Persist Security Info=False;User ID=kamiKaze;Password=p0m1d0r4s.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterWindow reg = new RegisterWindow();
            reg.ShowDialog();

        }

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                textBox2.Focus();

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login.PerformClick();

            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();                                                //prisijungiam prie db
                SqlCommand cmd = connect.CreateCommand();                      // sukuriam komanda
                cmd.CommandType = CommandType.Text;                             //nustatom komanda teksto tipo
                cmd.CommandText = "SELECT * FROM Users WHERE Email='" + Email.Text + "'AND Password='" + textBox2.Text + "'";                        // parenkam visa lentele 
                cmd.ExecuteNonQuery();                                           //vykdom komandine cmd eilute
                DataTable dt = new DataTable();                                //sukuriam saugojimui duomenu lentele
                SqlDataAdapter da = new SqlDataAdapter(cmd);                   //sukuriam sql duomenu adapteri, kurie jau yra isspausdinti cmd                           
                da.Fill(dt);                                                //uzpildom duomenu lentele dt
                int i = dt.Rows.Count;                                          //surandame ar yra nors viena eilute su tokiais duomenim
                if (i == 1)                                             //jei yra 1, tada cool, prisijungta sekminga
                {
                    MainMenu main = new MainMenu(Email.Text, this);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    Email.Text = null;
                    textBox2.Text = null;
                    MessageBox.Show("Atsiprašome, bet el. pašto adresas arba slaptažodis neteisingi!");
                }
                connect.Close();                  //atsijungiam nuo db
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void PremiumLogin_Click(object sender, EventArgs e)
        {   
            PremiumOperations po = new PremiumOperations();

            LoginDetails login = po.GetPremiumLogin();
            if (login != null)    //Has a premium file
            {
                User loggedUser = AccOps.RetrieveUserData(login.email, login.password);
                GoToMainMenu(loggedUser.Email);
            }
            else                  //No premium file, but hoping for premium acc
            {
                User loggedUser = AccOps.RetrieveUserData(Email.Text, textBox2.Text);
                if (loggedUser != null && loggedUser.Premium == true) //if correct details and is premium
                {
                    po.WritePremiumUserFile(new LoginDetails(Email.Text, textBox2.Text)); //TODO move PremiumFile creation to different login button?
                    login = po.GetPremiumLogin();
                    GoToMainMenu(login.email);
                }
                else
                {
                    //TODO print an error message
                }
            }
        }

        private void GoToMainMenu(string Email)
        {
            MainMenu main = new MainMenu(Email, this);
            main.Show();
            this.Hide();
        }
    }
}
