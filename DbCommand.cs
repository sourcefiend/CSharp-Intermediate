using System;

namespace Classes
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _dbCommand;

        public DbCommand(DbConnection db, string databaseCommand)
        {
            if (db == null || String.IsNullOrEmpty(databaseCommand) || String.IsNullOrWhiteSpace(databaseCommand))
                throw new ArgumentNullException("A database / database command can't be null.");

            _dbConnection = db;
            _dbCommand = databaseCommand;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("{0} - executed by {1}", _dbCommand, _dbConnection);
            _dbConnection.Close();
        }


    }
}