using System;
using System.IO;
using System.Threading;

namespace Exercises_S5_L31
{
    public abstract class DbConnection
    {
        public string _connectionString;
        public TimeSpan _timeout;

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidDataException("Connection string cannot be null or empty.");
            }
            _connectionString = connectionString;
            _timeout = TimeSpan.FromMilliseconds(2000);
        }
        
        public abstract void OpenConnnection();
        public abstract void CloseConnection();
    }
}