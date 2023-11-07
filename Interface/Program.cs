using Interface.CarDrive.CarType;
using Interface.Database;
using Interface.Database.DatabaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Automobile();
            car1.StartCar();
            car1.GearUp(4);
            car1.StopCar();



        }
    }
}
