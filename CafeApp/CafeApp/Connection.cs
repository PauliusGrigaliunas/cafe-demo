using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp
{
    public class Connector
    {
        private SqlConnection _connect = new SqlConnection
            ("Server = tcp:covfefedb.database.windows.net, 1433; Initial Catalog = covfefe; Persist Security Info=False;User ID = { your_username }; Password={your_password}; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");

        public SqlConnection SqlConnection { get { return _connect;}}


    }
}
