using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class DatabaseConnection
    {
        public static SqlConnection Connection()
        {
            return new SqlConnection("Server=tcp:covfefedb.database.windows.net,1433;Initial Catalog=covfefe;Persist Security Info=False;User ID=kamiKaze;Password=p0m1d0r4s.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
