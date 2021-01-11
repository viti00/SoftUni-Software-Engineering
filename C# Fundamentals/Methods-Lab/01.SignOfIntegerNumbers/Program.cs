using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
