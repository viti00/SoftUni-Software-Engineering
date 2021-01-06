using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digitSum = 0;
            int digit = num;
            while (digit > 0)
            {
                digitSum += digit % 10;
                digit = digit / 10;
            }
            Console.WriteLine(digitSum);
        }
    }
}
