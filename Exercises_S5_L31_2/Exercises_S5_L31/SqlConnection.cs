using System;

namespace Exercises_S5_L31_2
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnnection()
        {
            Console.WriteLine("SqlConnection open: " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection closed.");
        }
    }
}