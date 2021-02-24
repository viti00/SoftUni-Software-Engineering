using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 1; i <= n; i++)
            {
                string carsInformation = Console.ReadLine();
                string[] temp = carsInformation.Split("|");
                string carModel = temp[0];
                int carMil = int.Parse(temp[1]);
                int carFuel = int.Parse(temp[2]);
                cars.Add(carModel, new List<int> { carMil, carFuel });
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string car = "";
                string[] token = command.Split(" : ");
                string instruction = token[0];
                switch (instruction)
                {
                    case "Drive":
                        car = token[1];
                        int distance = int.Parse(token[2]);
                        int fuel = int.Parse(token[3]);
                        if (cars[car][1] < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car][0] += distance;
                            cars[car][1] -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        break;
                    case "Refuel":
                        car = token[1];
                        int fuelToRefuel = int.Parse(token[2]);
                        int curr = cars[car][1];
                        int refuel = 0;
                        if (cars[car][1] + fuelToRefuel > 75)
                        {
                            refuel = 75 - curr;
                            Console.WriteLine($"{car} refueled with {refuel} liters");
                            cars[car][1] = 75;
                        }
                        else
                        {
                            refuel = fuelToRefuel;
                            Console.WriteLine($"{car} refueled with {refuel} liters");
                            cars[car][1] += fuelToRefuel;
                        }
                        break;
                    case "Revert":
                        car = token[1];
                        int kmToDecrease = int.Parse(token[2]);
                        if (cars[car][0] - kmToDecrease >= 10000)
                        {

                            cars[car][0] -= kmToDecrease;
                            Console.WriteLine($"{car} mileage decreased by {kmToDecrease} kilometers");
                        }
                        else
                        {
                            cars[car][0] = 10000;
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
