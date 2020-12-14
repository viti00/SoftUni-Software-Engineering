using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double price = 0.0;
            switch (season)
            {
                case "Spring":
                    if (km <= 5000)
                    {
                        price = km * 0.75;
                    }
                    else if (km > 5000 && km <= 10000)
                    {
                        price = km * 0.95;
                    }
                    else if (km > 10000 && km <= 20000)
                    {
                        price = km * 1.45;
                    }
                    break;
                case "Summer":
                    if (km <= 5000)
                    {
                        price = km * 0.90;
                    }
                    else if (km > 5000 && km <= 10000)
                    {
                        price = km * 1.10;
                    }
                    else if (km > 10000 && km <= 20000)
                    {
                        price = km * 1.45;
                    }
                    break;
                case "Autumn":
                    if (km <= 5000)
                    {
                        price = km * 0.75;
                    }
                    else if (km > 5000 && km <= 10000)
                    {
                        price = km * 0.95;
                    }
                    else if (km > 10000 && km <= 20000)
                    {
                        price = km * 1.45;
                    }
                    break;
                case "Winter":
                    if (km <= 5000)
                    {
                        price = km * 1.05;
                    }
                    else if (km > 5000 && km <= 10000)
                    {
                        price = km * 1.25;
                    }
                    else if (km > 10000 && km <= 20000)
                    {
                        price = km * 1.45;
                    }
                    break;
            }
            double totalPrice = price * 4;
            double finalPrice = totalPrice - (totalPrice * 0.1);
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
