using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> listCars = new Dictionary<string, List<double>>();

            Car car = new Car();
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split();

                car.Model = splitted[0];
                car.FuelAmount = int.Parse(splitted[1]);
                car.FuelConsumptionPerKilometer = double.Parse(splitted[2]);
                car.TravelledDistance = 0;

                listCars.Add(car.Model, new List<double> { car.FuelAmount, car.FuelConsumptionPerKilometer, car.TravelledDistance });
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] splitted = command.Split();

                string model = splitted[1];
                double distance = double.Parse(splitted[2]);

                car.Drive(model, distance, listCars);

                command = Console.ReadLine();
            }

            foreach (var cars in listCars)
            {
                Console.WriteLine($"{cars.Key} {cars.Value[0]:F2} {cars.Value[2]}");
            }
        }
    }
}
