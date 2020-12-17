using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double increase = 0.0;
            double bankAcount = 0.0;
            while (input != "NoMoreMoney")
            {
                increase = double.Parse(input);
                if (increase < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                bankAcount += increase;
                Console.WriteLine($"Increase: {increase:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {bankAcount:F2}");
        }
    }
}
