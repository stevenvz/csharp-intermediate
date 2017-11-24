using System;

namespace Exercises_S5_L31_2
{
    public class DbCommand
    {
        public DbConnection DbConnection;
        public string Instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            DbConnection = connection ?? throw new InvalidOperationException("No open database connection.");
            Instruction = instruction ?? throw new InvalidOperationException("No instruction provided.");
        }

        public void Execute()
        {
            DbConnection.OpenConnnection();
            Console.WriteLine(Instruction + " executed.");
            DbConnection.CloseConnection();
        }

    }
}