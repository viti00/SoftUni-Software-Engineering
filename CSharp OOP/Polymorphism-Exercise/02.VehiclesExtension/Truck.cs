using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption + 1.6;
            TankCapacity = tankCapacity;

        }

        public override void Drive(double kilometers)
        {
            double consumption = kilometers * FuelConsumption;
            if (FuelQuantity >= consumption)
            {
                FuelQuantity -= consumption;
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            double refulledOil = liters - liters * 0.05;
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            
            else if (FuelQuantity + refulledOil <= TankCapacity)
            {
                FuelQuantity += refulledOil;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
