using System;

namespace _02.VehiclesExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] truckData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle car;
            Vehicle truck;
            Vehicle bus;


                car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));

                truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));

                bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] splitted = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if(splitted[0] == "Drive")
                {
                    if (splitted[1] == "Car")
                    {
                        car.Drive(double.Parse(splitted[2]));
                    }
                    else if (splitted[1] == "Truck")
                    {
                        truck.Drive(double.Parse(splitted[2]));
                    }
                    else if (splitted[1] == "Bus")
                    {
                        
                        bus.Drive(double.Parse(splitted[2]));
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
                    else if (splitted[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(splitted[2]));
                    }
                }
                else if (splitted[0] == "DriveEmpty")
                {
                    bus.FuelConsumption = double.Parse(busData[2]);
                    bus.Drive(double.Parse(splitted[2]));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
