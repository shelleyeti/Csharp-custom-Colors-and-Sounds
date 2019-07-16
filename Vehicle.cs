using System;

namespace custom_colors_and_sounds
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"You're turning {direction}");
        }

        public virtual void Stop(string vehicle)
        {
            Console.WriteLine($"The {vehicle} is stopping.");
        }
    }
}