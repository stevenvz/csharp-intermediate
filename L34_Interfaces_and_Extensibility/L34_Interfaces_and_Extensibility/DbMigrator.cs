using System;

namespace L34_Interfaces_and_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            //migrating the database

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}