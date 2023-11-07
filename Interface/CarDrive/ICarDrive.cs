using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.CarDrive
{
    public interface ICarDrive
    {
        void StartCar();
        void GearUp(int gear);
        void GearDown(int gear);
        void StopCar();

    }
}
