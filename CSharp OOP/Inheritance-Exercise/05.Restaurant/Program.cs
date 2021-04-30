using System;
namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = "IceCream";

            Cake cake = new Cake(name);

            Console.WriteLine($"{cake.Name} {cake.Price} {cake.Grams} {cake.Calories}");


            string coffeeName = "NovaBraziliq";
            double caffeine = 2.7;


            Coffee coffee = new Coffee(coffeeName, caffeine);

            Console.WriteLine($"{coffee.Name} {coffee.Price} {coffee.Mililiters} {coffee.Caffeine}");
        }
    }
}