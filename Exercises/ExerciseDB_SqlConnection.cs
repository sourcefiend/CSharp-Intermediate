using System;

namespace Classes
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override void Close()
        {
            Console.WriteLine("SQL Connection closed.");
        }

        public override void Open()
        {
            Console.WriteLine("SQL Connection opened.");
        }
    }
}