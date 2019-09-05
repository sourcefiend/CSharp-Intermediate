using System;

namespace Classes
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override void Close()
        {
            Console.WriteLine("Oracle Connection closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection opened.");
        }
    }
}