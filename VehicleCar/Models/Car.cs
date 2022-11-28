using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCar.Interface;

namespace VehicleCar.Models
{

    internal class Car:Vehicle,IEngine
    {
        byte _doorCount;

        public byte DoorCount 
        {
            get => _doorCount;
            set
            {
                if (value>=1)
                    _doorCount = value;
            } 
        }

        public float OilCapacity { get; set; }
        public float CurrentOil { get; set; }
        public string FuelType { get; set; }

        public float RemainOilAmount()
        {
            if(OilCapacity - CurrentOil >= 0)
                return OilCapacity - CurrentOil;
            else
                return 0;
        }
    }
}
