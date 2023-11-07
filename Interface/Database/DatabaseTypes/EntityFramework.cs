using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Database.DatabaseTypes
{
    public class EntityFramework : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("Entity framework tarafından eklendi");
        }

        public void Connection()
        {
            Console.WriteLine("Entity framework bağlantı sağlandı.");
        }
    }
}
