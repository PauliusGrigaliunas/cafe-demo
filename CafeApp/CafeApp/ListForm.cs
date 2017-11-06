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
using System.Device.Location;

namespace CafeApp
{
    public partial class ListForm : Form
    {

        Connector connector = new Connector();
        SqlConnection connect;
        SqlDataReader dr;

        public int id;
        string email;
        public ListForm(string email)
        {
            connection = new SqlConnection(connector.ConnectionString);

            this.email = email;
            InitializeComponent();

            listViewCafe.View = View.Details; //ability to select row
            listViewCafe.FullRowSelect = true; //ability to select row

        }

        private void ListForm_Activated(object sender, EventArgs e)
        {
            listViewCafe.Items.Clear();
            populateCafe();
        }

        private void populateCafe()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Cafes";
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

        private void ListForm_Load(object sender, EventArgs e)
        {
            Address address = Address.Instance;
            Address.Instance.watcher = new GeoCoordinateWatcher();
            Address.Instance.coordinate = new GeoCoordinate();
            Address.Instance.watcher.StatusChanged += watcher_StatusChanged;
            Address.Instance.watcher.Start();
        }

        private void watcher_StatusChanged(Object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                if (Address.Instance.watcher.Position.Location.IsUnknown)
                {
                    searchBox.Text = "Location is unknown";
                }
                else
                {
                    Address.Instance.coordinate = Address.Instance.watcher.Position.Location;
                }
            }
        }

        private void ShowInfo_Click(object sender, EventArgs e)
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

        private void BookTable_Click(object sender, EventArgs e)
        {
            new BookingForm(id, email).ShowDialog();
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Cafes";

            listViewCafe.Items.Clear();
            {
                try
                {
                    connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {

                        if (dr["Name"].ToString().Contains(searchBox.Text) || searchBox.Text == String.Empty)
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

        private void SearchLocation_Click(object sender, EventArgs e)
        {
            Address address = Address.Instance;

            var city = address.ReverseGeocode();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Cafes";

            listViewCafe.Items.Clear();
            {
                try
                {
                    connection.Open();
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {

                        if (dr["Address"].ToString().Contains(city))
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


