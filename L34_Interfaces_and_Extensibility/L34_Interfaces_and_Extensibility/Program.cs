using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L34_Interfaces_and_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\steve\\log17.txt"));
            dbMigrator.Migrate();
        }
    }
}
