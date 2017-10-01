using System;

namespace CafeApp
{
    public class Table
    {
        public int _id;
        public string _kavinesPavadinimas;  //In DB: Kavine
        public int _vietuSkaicius;          //In DB: Vietos

        //ISO 8601 format
        //YYYY-MM-DDThh:mm:ss
        //The T indicates the start of the time part of the datetime value.
        public DateTime _reservedOnFullDate;//In DB: Rezervuota 
        public TimeSpan _reservedOnHours;

        public Table(int id, string kavinespavadinimas, DateTime reservedOnFullDate) //Pretty much just a testing constructor
        {
            _id = id;
            _kavinesPavadinimas = kavinespavadinimas;
            ChangeReservedDate(reservedOnFullDate);
        }

        public Table(int id, string kavinesPavadinimas) //The regular constructor
        {
            _id = id;
            _kavinesPavadinimas = kavinesPavadinimas;
        }

        public void ChangeReservedDate(DateTime newDate)
        {
            _reservedOnFullDate = newDate;
            _reservedOnHours = _reservedOnFullDate.TimeOfDay;
        }

        void ChangeReservedTime(TimeSpan newTime)
        {
            _reservedOnHours = newTime;
        }

        void addTableToDatabase()
        {
            //TODO add-to-DB code
        }
    }
}
