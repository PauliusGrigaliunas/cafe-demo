using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using GoogleDirections;

namespace CafeApp
{
    public sealed class Address
    {
        private Geocoder geocoder = new Geocoder("AIzaSyBCSrZJLMW4FiC85dC7TW6XSxBOFn7LGwU");
        public GeoCoordinateWatcher watcher { set; get; }
        public GeoCoordinate coordinate { set; get; }


        private static Address instance = null;
        private static readonly object padlock = new object();

        private Address()
        {

        }

        public static Address Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Address();


                    }
                    return instance;
                }
            }
        }

        public String ReverseGeocode()
        {
            return geocoder.ReverseGeocodeComponents(new LatLng(coordinate.Latitude, coordinate.Longitude))["locality"];
        }
    }
      
}
