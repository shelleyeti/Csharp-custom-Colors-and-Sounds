using System;

namespace custom_colors_and_sounds
{
    public class Ram : GasVehicle
    { // Gas powered truck

        public string TowCapacity { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("RRrrrrrummbbble!");
        }
    }
}