using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        price += 2.50;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        price += 1.25;
                    }
                    else
                    {
                        price += 1;
                    }
                }
                totalPrice += price;
                Console.WriteLine($"Day: {i} - {price:f2} leva");
                price = 0;
            }
            Console.WriteLine($"Total: {totalPrice:F2} leva");
        }
    }
}
