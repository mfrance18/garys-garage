using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine($"Charging {Name}!");
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you! Yeeooooww!");
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
