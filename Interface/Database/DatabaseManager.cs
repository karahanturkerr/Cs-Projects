using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Database
{
    public class DatabaseManager
    {
        private IDatabase _database;
        public DatabaseManager(IDatabase database)
        {
            _database = database;
        }

        public void ConnectionOpen()
        {
            _database.Connection();
        }
    }
}
