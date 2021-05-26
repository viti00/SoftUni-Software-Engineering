using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension
{
    public abstract class Vehicle
    {

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {

            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }
        public double TankCapacity { get; set; }

        public double FuelQuantity { get; set; }
        

        public double FuelConsumption { get; set; }


        public abstract void Drive(double kilometers);

        public abstract void Refuel(double liters);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
