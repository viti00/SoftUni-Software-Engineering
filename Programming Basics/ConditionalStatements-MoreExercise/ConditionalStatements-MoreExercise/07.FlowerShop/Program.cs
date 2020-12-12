using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            string output = "";
            string fuel1 = "Gasoline";
            string fuel2 = "Diesel";
            string fuel3 = "Gas";
            string output1 = "";
            if (fuel != fuel1 && fuel != fuel2 && fuel != fuel3)
            {
                output = $"Invalid fuel!";
            }
            else if (amount < 25)
            {
                if (fuel == fuel1)
                {
                    output1 = "gasoline";
                    output = $"Fill your tank with {output1}!";
                }
                else if (fuel == fuel2)
                {
                    output1 = "diesel";
                    output = $"Fill your tank with {output1}!";
                }
                else if (fuel == fuel3)
                {
                    output1 = "gas";
                    output = $"Fill your tank with {output1}!";
                }
            }
            else if (amount >= 25)
            {
                if (fuel == fuel1)
                {
                    output1 = "gasoline";
                    output = $"You have enough {output1}.";
                }
                else if (fuel == fuel2)
                {
                    output1 = "diesel";
                    output = $"You have enough {output1}.";
                }
                else if (fuel == fuel3)
                {
                    output1 = "gas";
                    output = $"You have enough {output1}.";
                }
            }
            Console.WriteLine(output);
        }
    }
}
