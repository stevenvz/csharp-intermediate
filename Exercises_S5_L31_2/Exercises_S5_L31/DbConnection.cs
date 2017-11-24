using System;
using System.IO;
using System.Threading;

namespace Exercises_S5_L31_2
{
    public abstract class DbConnection
    {
        public string ConnectionString;
        public TimeSpan Timeout;

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidDataException("Connection string cannot be null or empty.");
            }
            ConnectionString = connectionString;
            Timeout = TimeSpan.FromMilliseconds(2000);
        }
        
        public abstract void OpenConnnection();
        public abstract void CloseConnection();
    }
}