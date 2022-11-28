using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCar.Models
{
    internal class Bicycle
    {
        string _pedalKind;

        public string PedalKind 
        {
            get => _pedalKind;
            set
            {
                value = value.Trim();   
                if (value.Length >=2)
                    _pedalKind = value;
            } 
        }
    }
}
