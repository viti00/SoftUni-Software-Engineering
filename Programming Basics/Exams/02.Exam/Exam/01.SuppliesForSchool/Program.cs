using System;

namespace _01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double priceForPen = pen * 5.80;
            double priceForMarkers = markers * 7.20;
            double preparation = litres * 1.20;
            double totalPrice = priceForPen + priceForMarkers + preparation;
            double finalPrice = totalPrice - ((totalPrice * discount) / 100);
            Console.WriteLine($"{finalPrice:f3}");
        }
    }
}
