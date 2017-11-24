using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L31
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleConnection = new OracleConnection("Oracle connection string");
            oracleConnection.OpenConnnection();
            oracleConnection.CloseConnection();

            var sqlConnection = new SqlConnection("SQL connection string");
            sqlConnection.OpenConnnection();
            sqlConnection.CloseConnection();
        }
    }
}
