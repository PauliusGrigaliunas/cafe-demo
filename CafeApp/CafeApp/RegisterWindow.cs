﻿using System;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CafeApp
{
    public partial class RegisterWindow : Form
    {

        public string name;
        public string surname;
        public string e_mail;  // NOTE: Email = username
        public string password;
        public bool inserted=false;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Albert\Documents\GitHub\cafe-demo\CafeApp\CafeApp\Database1.mdf;Integrated Security=True");



        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            surname = textBox2.Text;
            e_mail = textBox3.Text;
            password = textBox4.Text;
            /// TODO: Validation system (check for valid email, password. 
            /// After validating data INSTERT TO DB
            /// Note: Don't forget about try/catch 
            
            if (IsValidEmail(e_mail)&& IsValidPassword(password))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Users";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter(cmd);
                    sa.Fill(dt);
                    if (!CheckIfMailExists(dt, textBox3.Text) && !inserted)
                    {
                        cmd.CommandText = "INSERT INTO Users (Email,Password,Name,Surname) VALUES('"+textBox3.Text+ "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                        cmd.ExecuteNonQuery();
                        inserted = true;
                        MessageBox.Show("User successfully registered!");
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("User already exists, please choose different email or login into our system.");
                        connection.Close();
                    }
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
            else
            {
                MessageBox.Show("Your email or password are incorrect, please, check them and try again.");
            }
            this.Close();
        }

        private bool IsValidEmail (string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPassword (string password)
        {
            try
            {
                int length = password.Length;
                return length >= 6;
            }
            catch
            {
                return false;
            }
        }
        private bool CheckIfMailExists(DataTable dt, string data)
        {

            bool exists = false;
            for (int i=0; i < dt.Rows.Count; i++)
            {
                if (data == dt.Rows[i][0].ToString())
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
