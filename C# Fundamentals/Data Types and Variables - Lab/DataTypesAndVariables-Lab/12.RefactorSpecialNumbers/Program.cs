using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digitSum = 0;
            int digit = 0;
            bool isSpecialNumber = false;
            for (int ch = 1; ch <= n; ch++)
            {
                digit = ch;
                while (ch > 0)
                {
                    digitSum += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNumber = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
                Console.WriteLine("{0} -> {1}", digit, isSpecialNumber);
                digitSum = 0;
                ch = digit;
            }
        }
    }
}
