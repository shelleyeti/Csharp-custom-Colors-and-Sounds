using System;

namespace custom_colors_and_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The motorcycle");
            Zero Motorcycle = new Zero();

            Motorcycle.MaximumOccupancy = "2";
            Console.WriteLine($"Motorcycle max occupancy: {Motorcycle.MaximumOccupancy}");
            Motorcycle.ChargeBattery();
            Motorcycle.Drive();
            Motorcycle.Stop("motorcycle");

            Console.WriteLine("The Tesla");
            Tesla Car = new Tesla();

            Car.MaximumOccupancy = "5";
            Console.WriteLine($"Car max occupancy: {Car.MaximumOccupancy}");
            Car.SelfDriving = true;
            Console.WriteLine($"Car self driving: {Car.SelfDriving}");
            Car.ChargeBattery();
            Car.Drive();

            Console.WriteLine("The Ram");
            Ram Truck = new Ram();

            Truck.MaximumOccupancy = "2";
            Console.WriteLine($"Truck max occupancy: {Truck.MaximumOccupancy}");
            Truck.TowCapacity = "1 ton";
            Console.WriteLine($"Truck tow capacity: {Truck.TowCapacity}");
            Truck.Drive();
            Truck.Turn("left");

            Console.WriteLine("The Plane");
            Cessna Plane = new Cessna();

            Plane.MaximumOccupancy = "4";
            Console.WriteLine($"Plane max occupancy: {Plane.MaximumOccupancy}");
            Plane.Drive();
            Plane.Stop("plane");

            Console.WriteLine("The CR-V");
            Honda Crv = new Honda();

            Crv.MaximumOccupancy = "5";
            Console.WriteLine($"CRV max occupancy: {Crv.MaximumOccupancy}");
            Crv.Drive();
            Crv.Turn("right");

        }
    }
}
