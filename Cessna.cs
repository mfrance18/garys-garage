using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine($"Refueling {Name}");
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessa zooms by you! Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully banks {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop");
        }
    }
}
