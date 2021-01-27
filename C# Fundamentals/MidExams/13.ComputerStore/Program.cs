using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalWhitoutTax = 0;
            double taxes = 0;
            double totalPrice = 0;
            double finalPrice = 0;
            while (command != "special" && command != "regular")
            {
                double pricesWhitoutTaxes = double.Parse(command);
                if (pricesWhitoutTaxes < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else if (pricesWhitoutTaxes >= 0)
                {
                    totalWhitoutTax += pricesWhitoutTaxes;
                    taxes += pricesWhitoutTaxes * 0.20;
                }
                command = Console.ReadLine();
                if (command == "special")
                {
                    totalPrice = totalWhitoutTax + taxes;
                    finalPrice = totalPrice - totalPrice * 0.10;
                }
                else if (command == "regular")
                {
                    totalPrice = totalWhitoutTax + taxes;
                    finalPrice = totalPrice;
                }
            }
            if (finalPrice > 0)
            {

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalWhitoutTax:F2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
