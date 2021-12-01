using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
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
            Console.WriteLine($"The {MainColor} Ram growls by you. RRRRuummmmble!!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop");
        }
    }
}
