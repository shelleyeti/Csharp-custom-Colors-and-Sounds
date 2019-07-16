using System;

namespace custom_colors_and_sounds
{
    public class ElectricVehicle : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery charging...");
        }

        public override void Drive()
        {
            Console.WriteLine("...");
        }

        public override void Stop(string vehicle)
        {
            Console.WriteLine($"The {vehicle} coasts to a gentle stop.");
        }
    }
}