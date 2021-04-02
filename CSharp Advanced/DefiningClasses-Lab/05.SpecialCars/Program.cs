using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<List<int>> tireYears = new List<List<int>>();
            List<List<double>> tirePressure = new List<List<double>>();
            List<int> listHorsePowers = new List<int>();
            List<double> listCubicsCapacity = new List<double>();

            List<Car> listCars = new List<Car>();

            Tire tires = new Tire();
            Engine engine = new Engine();

            string tireCommand = Console.ReadLine();
            while(tireCommand != "No more tires")
            {
                string[] splitted = tireCommand.Split();

                List<int> listTireYears = tires.GetYear(splitted);
                List<double> listTirePressure = tires.GetPressure(splitted);

                tireYears.Add(listTireYears);
                tirePressure.Add(listTirePressure);

                tireCommand = Console.ReadLine();
            }

            string engineCommand = Console.ReadLine();

            while(engineCommand != "Engines done")
            {
                string[] splitted = engineCommand.Split();

                listHorsePowers.Add(engine.GetHorsePower(splitted));
                listCubicsCapacity.Add(engine.GetCubicCapacity(splitted));

                engineCommand = Console.ReadLine();
            }

            string carsInput = Console.ReadLine();

            while(carsInput != "Show special")
            {
                string[] splitted = carsInput.Split();

                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tireIndex = int.Parse(splitted[6]);

                int horsePower = listHorsePowers[engineIndex];
                double pressure = tires.GetPressureSum(tirePressure, tireIndex);

                Car car = new Car(make, model, year, horsePower, fuelQuantity, fuelConsumption,
                    engineIndex, tireIndex, pressure);

                listCars.Add(car);

                carsInput = Console.ReadLine();
            }
            foreach (var car in listCars)
            {
                if (car.Year >= 2017 && car.HorsePower > 330
                    && car.TotalPressure > 9 && car.TotalPressure < 10)
                {
                    car.FuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);

                    Console.WriteLine($"Make: {car.Make}");

                    Console.WriteLine($"Model: {car.Model}");

                    Console.WriteLine($"Year: {car.Year}");

                    Console.WriteLine($"HorsePowers: {car.HorsePower}");

                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
