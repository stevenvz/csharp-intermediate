using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S5_L31_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCommand = new DbCommand(new SqlConnection("SQL data"), "JOIN");
            dbCommand.Execute();
        }
    }
}
