using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }
        public int Count { get { return cars.Count; } }

        public void Add (Car car)
        {
            if (cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove (string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(p => p.Manufacturer == manufacturer && p.Model == model);
            if (car == null)
            {
                return false;
            }
            cars.Remove(car);
            return true;
        }

        public Car GetLatestCar()
        {
            return cars.OrderByDescending(p => p.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(p => p.Manufacturer == manufacturer && p.Model == model);

            return car;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {Type}:");
            for (int i = 0; i < cars.Count - 1; i++)
            {
                sb.AppendLine(cars[i].ToString());
            }
            sb.Append(cars[cars.Count - 1]);

            return sb.ToString();
        }
    }
}
