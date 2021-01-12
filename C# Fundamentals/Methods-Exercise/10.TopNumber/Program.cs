using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumber(num);
        }
        static void TopNumber(int n)
        {
            int digitSum = 0;

            for (int curr = 17; curr <= n; curr++)
            {
                int number = curr;
                int digit = curr;
                while (digit > 0)
                {
                    digitSum += digit % 10;
                    int currDigit = digit % 10;
                    digit = digit / 10;
                    if (currDigit % 2 == 1)
                    {
                        if (digitSum % 8 == 0)
                        {
                            Console.WriteLine(number);
                        }
                    }
                }
                digitSum = 0;
            }
        }
    }
}
