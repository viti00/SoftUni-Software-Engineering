using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption + 1.4;
            TankCapacity = tankCapacity;
        }

        public override void Drive(double kilometers)
        {

            double consumption = kilometers * FuelConsumption;
            if (FuelQuantity >= consumption)
            {
                FuelQuantity -= consumption;
                Console.WriteLine($"Bus travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FuelQuantity + liters <= TankCapacity)
            {
                FuelQuantity += liters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
