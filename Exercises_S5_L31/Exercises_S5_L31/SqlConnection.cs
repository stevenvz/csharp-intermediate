using System;

namespace Exercises_S5_L31
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnnection()
        {
            Console.WriteLine("SqlConnection open: " + _connectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection closed.");
        }
    }
}