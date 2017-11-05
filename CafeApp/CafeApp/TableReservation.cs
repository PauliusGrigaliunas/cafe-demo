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

    class TableReservation
    {
        private SqlConnection connection = new SqlConnection("Server=tcp:covfefedb.database.windows.net,1433;Initial Catalog=covfefe;Persist Security Info=False;User ID=kamiKaze;Password=p0m1d0r4s.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private SqlDataReader sqlDataReader;

        string _kavinesPavadinimas;
        List<Table> allTables = new List<Table>();
        List<Table> availableTables = new List<Table>();

        public TableReservation(string kavinesPavadinimas)
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
                    DateTime readRezervuota = DateTime.MinValue; //Can't be assigned NULL, so we'll assume min value is NULL
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
