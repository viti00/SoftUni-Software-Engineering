using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            firstCar.Drive(200);
            Console.WriteLine(firstCar.WhoAmI());

            Car secondCar = new Car(make, model, year);
            secondCar.Drive(200);
            Console.WriteLine(secondCar.WhoAmI());

            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            thirdCar.Drive(200);
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
