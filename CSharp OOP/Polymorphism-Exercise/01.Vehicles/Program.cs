using System;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split();
            string[] truckData = Console.ReadLine().Split();

            Vehichle car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));

            Vehichle truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] splitted = command.Split();

                if (splitted[0] == "Drive")
                {
                    if (splitted[1] == "Car")
                    {
                        car.Drive(double.Parse(splitted[2]));
                    }
                    else if ( splitted[1] == "Truck")
                    {
                        truck.Drive(double.Parse(splitted[2]));
                    }
                }
                else if (splitted[0] == "Refuel")
                {
                    if (splitted[1] == "Car")
                    {
                        car.Refuel(double.Parse(splitted[2]));
                    }
                    else if (splitted[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(splitted[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
