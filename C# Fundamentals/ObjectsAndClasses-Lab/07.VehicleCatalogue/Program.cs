using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string data = Console.ReadLine();
            string model = string.Empty;
            string brand = string.Empty;
            string horsePower = string.Empty;
            string weight = string.Empty;
            while (data != "end")
            {
                string[] temp = data.Split("/");
                switch (temp[0])
                {
                    case "Car":
                        brand = temp[1];
                        model = temp[2];
                        horsePower = temp[3];
                        Car car = new Car();
                        car.Brand = brand;
                        car.Model = model;
                        car.HorsePower = horsePower;

                        cars.Add(car);
                        break;
                    case "Truck":
                        brand = temp[1];
                        model = temp[2];
                        weight = temp[3];
                        Truck truck = new Truck();
                        truck.Brand = brand;
                        truck.Model = model;
                        truck.Weight = weight;

                        trucks.Add(truck);
                        break;
                }
                data = Console.ReadLine();
            }
            List<Car> sortedCar = cars.OrderBy(sortCars => sortCars.Brand).ToList();
            List<Truck> sortedTruck = trucks.OrderBy(sortTrucks => sortTrucks.Brand).ToList();
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }



        }
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        public class CatalogVehicle
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
