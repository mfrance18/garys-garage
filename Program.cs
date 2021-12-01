using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero
            {
                MainColor = "Blue",
                Name = "Jerry",
                CurrentChargePercentage = 43
            };

            Zero fx = new Zero
            {
                MainColor = "Red",
                Name = "Ruby",
                CurrentChargePercentage = 54
            };

            Tesla modelS = new Tesla
            {
                MainColor = "Blue",
                Name = "Blue Moon",
                CurrentChargePercentage = 34
            };

            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
            Console.WriteLine("");

            fx.Drive();
            fx.Turn("Right");
            fx.Stop();
            Console.WriteLine("");

            modelS.Drive();
            modelS.Turn("Left");
            modelS.Stop();
            Console.WriteLine("");

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.Name} has {ev.CurrentChargePercentage}% battery left. Need to Charge!");
            }

            Console.WriteLine("");

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();

            }

            Console.WriteLine("");

            foreach (IElectricVehicle ev in electricVehicles)
            {

                Console.WriteLine($"{ev.Name} now has {ev.CurrentChargePercentage}% power!");
            }

            Console.WriteLine("");

            /***********************************************/

            Ram ram = new Ram
            {
                MainColor = "Silver",
                Name = "Jeff",
                CurrentTankPercentage = 45
            };

            Cessna cessna150 = new Cessna
            {
                MainColor = "Green",
                Name = "Hulk",
                CurrentTankPercentage = 33
            };



            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            ram.Drive();
            ram.Turn("Left");
            ram.Stop();
            Console.WriteLine("");

            cessna150.Drive();
            cessna150.Turn("Right");
            cessna150.Stop();
            Console.WriteLine("");

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.Name} has {gv.CurrentTankPercentage}% fuel left. Need to Refuel!");
            }

            Console.WriteLine("");

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            Console.WriteLine("");

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.Name} now has {gv.CurrentTankPercentage}% fuel!");
            }
        }
    }
}
