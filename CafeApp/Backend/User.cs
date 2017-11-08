using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class User
    {
        string _email;
        //password is left-out for security
        string _phone;
        string _name, _surname;
        bool _premium;

        public User(string email, string phone, string name, string surname, bool premium)
        {
            _email = email;
            _phone = phone;
            _name = name;
            _surname = surname;
            _premium = premium;
        }

        //public read-only values:
        public string Email { get => _email;}
        public string Phone { get => _phone; }
        public string Name { get => _name; }
        public string Surname { get => _surname; }
        public bool Premium { get => _premium; }

    }
}
