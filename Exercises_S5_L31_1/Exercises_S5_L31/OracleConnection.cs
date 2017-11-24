using System;

namespace Exercises_S5_L31
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnnection()
        {
            Console.WriteLine("OracleConnection open: " + _connectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("OracleConnection closed.");
        }
    }
}