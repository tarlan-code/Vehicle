using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCar.Interface
{
    interface IEngine
    {
        public float OilCapacity { get; set; }
        public float CurrentOil { get; set; }

        public string FuelType { get; set; }

        public float RemainOilAmount();
    }
}
