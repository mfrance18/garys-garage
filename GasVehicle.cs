using System;

namespace Garage
{
    public interface IGasVehicle
    {
        string Name { get; set; }
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }
        void RefuelTank();
    }
}