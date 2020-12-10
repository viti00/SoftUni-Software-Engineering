using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int vegetablesCount = int.Parse(Console.ReadLine());
            int fruitsCount = int.Parse(Console.ReadLine());
            double vegetablesPrice = vegetables * vegetablesCount;
            double fruitsPrice = fruits * fruitsCount;
            double totalPrice = vegetablesPrice + fruitsPrice;
            double euro = 1.94;
            double priceInEuro = totalPrice / euro;
            Console.WriteLine($"{priceInEuro:F2}");
        }
    }
}
