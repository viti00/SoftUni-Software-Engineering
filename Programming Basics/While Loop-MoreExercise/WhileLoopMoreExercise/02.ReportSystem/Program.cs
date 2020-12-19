using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int payCash = 0;
            int payCard = 0;
            int payCashCounter = 0;
            int payCardCounter = 0;
            int paymentCounter = 0;

            while (input != "End")
            {
                paymentCounter++;
                int productPrice = int.Parse(input);
                if (paymentCounter % 2 != 0 && productPrice <= 100)
                {
                    payCashCounter++;
                    totalSum -= productPrice;
                    payCash += productPrice;
                    Console.WriteLine($"Product sold!");
                }
                else if (paymentCounter % 2 == 0 && productPrice >= 10)
                {
                    payCardCounter++;
                    totalSum -= productPrice;
                    payCard += productPrice;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }

                if (totalSum <= 0)
                {
                    Console.WriteLine($"Average CS: {1.0 * payCash / payCardCounter:f2}");
                    Console.WriteLine($"Average CC: {1.0 * payCard / payCardCounter:f2}");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
