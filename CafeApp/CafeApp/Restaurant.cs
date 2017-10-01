using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp
{
    class Restaurant
    {
        string _name;
        string _address;
        string _phone;
        string _workdays;
        string _saturday;
        string _sunday;
        string _restaurantsEmail; //E-mail for customers to contact (Not the email it was registered with)
        TableReservation tableReservation; //<--- this has all table related fields

        public Restaurant(string name, string address)
        {
            _name = name;
            _address = address;
            tableReservation = new TableReservation(name);
        }

        public Restaurant(int id, string name, string address, string phone, int tables, string workdays, string saturday, string sunday, string restaurantsEmail)
        {
            _name = name;
            _address = address;
            _phone = phone;
            _workdays = workdays;
            _saturday = saturday;
            _sunday = sunday;
            _restaurantsEmail = restaurantsEmail;
            tableReservation = new TableReservation(name);
        }
    }
}
