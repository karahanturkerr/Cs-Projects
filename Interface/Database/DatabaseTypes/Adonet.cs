using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Database.DatabaseTypes
{
    public class Adonet : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("adonet tarafından eklendi");
        }

        public void Connection()
        {
            Console.WriteLine("adonet bağlantı sağlandı.");
        }
    }
}
