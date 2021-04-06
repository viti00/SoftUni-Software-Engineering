using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(string model, double distance, Dictionary<string, List<double>> cars)
        {
            if(cars[model][0] >= cars[model][1] * distance)
            {
                cars[model][0] -= (cars[model][1] * distance);
                cars[model][2] += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
