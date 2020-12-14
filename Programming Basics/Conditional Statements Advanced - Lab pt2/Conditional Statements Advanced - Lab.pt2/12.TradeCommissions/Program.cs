using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sels = double.Parse(Console.ReadLine());
            double commissions = 0.0;
            if (town == "Sofia")
            {
                if (sels >= 0 && sels <= 500)
                {
                    commissions = sels * 0.05;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 500 && sels <= 1000)
                {
                    commissions = sels * 0.07;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 1000 && sels <= 10000)
                {
                    commissions = sels * 0.08;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 10000)
                {
                    commissions = sels * 0.12;
                    Console.WriteLine($"{commissions:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sels >= 0 && sels <= 500)
                {
                    commissions = sels * 0.045;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 500 && sels <= 1000)
                {
                    commissions = sels * 0.075;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 1000 && sels <= 10000)
                {
                    commissions = sels * 0.1;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 10000)
                {
                    commissions = sels * 0.13;
                    Console.WriteLine($"{commissions:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sels >= 0 && sels <= 500)
                {
                    commissions = sels * 0.055;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 500 && sels <= 1000)
                {
                    commissions = sels * 0.08;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 1000 && sels <= 10000)
                {
                    commissions = sels * 0.12;
                    Console.WriteLine($"{commissions:F2}");
                }
                else if (sels > 10000)
                {
                    commissions = sels * 0.145;
                    Console.WriteLine($"{commissions:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
