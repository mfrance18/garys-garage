using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string Name { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Vehicle turns {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stops");
        }
    }
}



