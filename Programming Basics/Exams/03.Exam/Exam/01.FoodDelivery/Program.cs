using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double vegetarianMenuPrice = 8.15;

            double totalPrice = chickenMenu * chickenMenuPrice + fishMenu * fishMenuPrice + vegetarianMenu * vegetarianMenuPrice;
            double dessertPrice = totalPrice * 0.2;
            double finalPrice = totalPrice + dessertPrice + 2.50;
            Console.WriteLine($"Total: {finalPrice:f2}");
        }
    }
}
