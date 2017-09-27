using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using GoogleDirections;

namespace CafeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Geocoder geocoder = new Geocoder("AIzaSyBCSrZJLMW4FiC85dC7TW6XSxBOFn7LGwU");
        GeoCoordinateWatcher watcher = null;
        GeoCoordinate coordinate = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            watcher = new GeoCoordinateWatcher();
            coordinate = new GeoCoordinate();
            watcher.StatusChanged += watcher_StatusChanged;
            watcher.TryStart(false, TimeSpan.FromMilliseconds(300));
        }

        private void watcher_StatusChanged(Object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                if (watcher.Position.Location.IsUnknown)
                {
                    textBox1.Text = "Location is unknown";
                }
                else
                {
                    coordinate = watcher.Position.Location;      
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //returns a dictionary of full address
            var fullAddress = geocoder.ReverseGeocodeComponents(new LatLng(coordinate.Latitude, coordinate.Longitude));

            //prints the city and the country the user is currently in
            textBox1.Text = String.Format("City: {0} Country {1}", fullAddress["locality"], fullAddress["country"]);
        }
    }
}
