using System;

namespace Classes
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string can't be null or empty.");

            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}