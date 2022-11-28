using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCar.Models
{
    internal abstract class  Vehicle
    {
        float _driveTime;
        float _drivePath;

        public float DriveTime 
        {
            get => _driveTime;
            set
            {
                if (value >= 0)
                {
                    _driveTime = value;
                }
            } 
        }

        public float DrivePath
        {
            get => _drivePath;
            set
            {
                if (value>=0)
                {
                    _drivePath = value;
                }
            }
        }

        public float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
