using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double bugdet = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double dressFor1Statist = double.Parse(Console.ReadLine());
            double dekor = bugdet * 0.10;
            double priceForDress = statist * dressFor1Statist;
            double priceAfterDiscount = 0.0;
            string output = "";
            string output1 = "";
            if (statist > 150)
            {
                priceAfterDiscount = priceForDress - (priceForDress * 0.10);
            }
            else
            {
                priceAfterDiscount = priceForDress;
            }
            double totalPrice = dekor + priceAfterDiscount;
            double needed = 0.0;
            double more = 0.0;
            if (totalPrice > bugdet)
            {
                needed = totalPrice - bugdet;
                output = $"Not enough money!";
                output1 = $"Wingard needs {needed:F2} leva more.";
            }
            else if (totalPrice <= bugdet)
            {
                more = bugdet - totalPrice;
                output = $"Action!";
                output1 = $"Wingard starts filming with {more:F2} leva left.";
            }
            Console.WriteLine(output);
            Console.WriteLine(output1);
        }
    }
}
