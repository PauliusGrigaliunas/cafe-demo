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

namespace CafeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GeoCoordinateWatcher watcher = null;
        GeoCoordinate coordinate = null;
        CivicAddressResolver resolver = null;
        CivicAddress address = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            watcher = new GeoCoordinateWatcher();
            coordinate = new GeoCoordinate();
            resolver = new CivicAddressResolver();
            address = new CivicAddress();
            watcher.StatusChanged += watcher_StatusChanged;
            watcher.Start();
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
                    address = resolver.ResolveAddress(coordinate);

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text =String.Format("Latitude:{0} Longtitude{1}",address.CountryRegion, address.City);
        }
    }
}
