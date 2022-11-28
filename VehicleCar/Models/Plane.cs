using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCar.Interface;

namespace VehicleCar.Models
{
    internal class Plane:Vehicle,IEngine
    {
        byte _wingLength;

        public byte WingLength 
        {
            get => _wingLength;
            set
            {
                if(value >= 5 && value <= 50)
                    _wingLength = value;
            } 
        }

        public float OilCapacity { get; set; }
        public float CurrentOil { get; set; }
        public string FuelType { get; set; }


        public float RemainOilAmount()
        {
            if (OilCapacity - CurrentOil >= 0)
                return OilCapacity - CurrentOil;
            else
                return 0;
        }

    }
}
