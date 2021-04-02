using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        public Car(string make, string model, int year, int horsePower,
            double fuelQuantity, double fuelConsumption,
            int engineIndex, int tireIndex, double totalPressure)
        {
            Make = make;
            Model = model;
            Year = year;
            HorsePower = horsePower;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            EngineIndex = engineIndex;
            TireIndex = tireIndex;
            TotalPressure = totalPressure;
        }


        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int HorsePower { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public int EngineIndex { get; set; }

        public int TireIndex { get; set; }

        public double TotalPressure { get; set; }

        public double Drive20Kilometers(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (FuelConsumption / 100) * 20;

            return fuelQuantity;
        }
    }
}
