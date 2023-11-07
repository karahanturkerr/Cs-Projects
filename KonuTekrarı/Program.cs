using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonuTekrarı
{
    internal class Program
    {
        private static List<Footballer> Footballers = new List<Footballer>();
        static void Main(string[] args)
        {

            var ft4 = new Footballer("Muslera", 35, "urg", 1, 3);

            
           

        }

        private static void LoadFootballer()
        {
            var ft1 = new Footballer("Muslera", 35, "urg", 1, 3);
            var ft2 = new Footballer("X", 25, "tur", 13, 5);
            var ft3 = new Footballer("Y", 20, "spn", 8, 12);
            Footballers.Add(ft1);
            Footballers.Add(ft2);
            Footballers.Add(ft3);

        }
    }
}
