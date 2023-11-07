using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.CarDrive.CarType
{
    public class Truck : ICarDrive
    {
        public void GearDown(int gear)
        {
            Console.WriteLine(gear.ToString() + " Gear downed!!!");
        }

        public void GearUp(int gear)
        {
            Console.WriteLine(gear.ToString() + " Gear upted!!!");
        }

        public void StartCar()
        {
            Console.WriteLine("Car started!!!");
        }

        public void StopCar()
        {
            Console.WriteLine("Car stopted!!!");
        }
    }
}
