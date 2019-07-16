using System;

namespace custom_colors_and_sounds
{
    public class GasVehicle : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Tank is now full");
        }
    }
}