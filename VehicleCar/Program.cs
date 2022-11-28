using VehicleCar.Models;

namespace VehicleCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            car.DriveTime = 5;
            car.DrivePath = 2;
            car.CurrentOil = 5;
            car.OilCapacity = 10;
            Console.WriteLine($"Avergae Speed Car: {car.AverageSpeed()}");
            Console.WriteLine($"Remain Oil Amount Car: {car.RemainOilAmount()}");

            Plane plane = new Plane();
            plane.DriveTime = 5;
            plane.DrivePath = 20;
            plane.CurrentOil = 50;
            plane.OilCapacity = 100;
            Console.WriteLine($"Avergae Speed Plane: {plane.AverageSpeed()}");
            Console.WriteLine($"Remain Oil Amount Plane: {plane.RemainOilAmount()}");
        }
    }
}