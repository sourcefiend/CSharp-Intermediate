using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating the database.");
        }
    }
}
