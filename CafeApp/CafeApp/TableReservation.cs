using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public class Table
    {
        public int _id;
        public string _kavinesPavadinimas;

        //ISO 8601 format
        //YYYY-MM-DDThh:mm:ss
        //The T indicates the start of the time part of the datetime value.
        public DateTime _reservedOnFullDate;   
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

        }
    }

    class TableReservation
    {
        private SqlConnection connection = new SqlConnection("Server=tcp:cafeappdb.database.windows.net,1433;Initial Catalog=CafeAppDB;Persist Security Info=False;User ID=admincontrol34;Password=Admincontrol7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private SqlDataReader sqlDataReader;

        string _kavinesPavadinimas;
        List<Table> allTables = new List<Table>();
        List<Table> availableTables = new List<Table>();

        TableReservation(string kavinesPavadinimas)
        {
            _kavinesPavadinimas = kavinesPavadinimas;
            GetAllTables(kavinesPavadinimas);
        }


        public void GetAllTables(string kavinesPavadinimas)
        {
            //connection.Open(); //Bug: connection is not closed
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CafeTables WHERE Kavine = '"+ kavinesPavadinimas +"'";
            try
            {
                connection.Open();
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int readId = sqlDataReader.GetInt32(0); //Id column
                    string readKavine = sqlDataReader.GetString(1);
                    DateTime readRezervuota = DateTime.MinValue; //Can't be NULL, so we'll assume min value is NULL
                    if (!sqlDataReader.IsDBNull(2))
                        readRezervuota = sqlDataReader.GetDateTime(2);

                    allTables.Add(new Table(readId, readKavine, readRezervuota));
                }
            }
            catch (Exception ex)
            {
                Application.Run(new ErrorScreen(ex.ToString()));
            }
            finally
            {
                connection.Close();
            }
        }

        void GetAvailableTables(string kavinesPavadinimas)
        {
            //TODO GetAvailableTables
        }

    }
}
