using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            int multiplySum = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            return multiplySum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            int digit = number;
            while (digit > 0)
            {
                int digitFromNumber = number % 10;
                digit = digit / 10;
                if (digitFromNumber % 2 == 0)
                {
                    evenSum += digitFromNumber;
                }
                number = digit;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int digit = number;
            int oddSum = 0;
            while (digit > 0)
            {
                int digitFromNumber = number % 10;
                digit = digit / 10;
                if (digitFromNumber % 2 == 1)
                {
                    oddSum += digitFromNumber;
                }
                number = digit;
            }
            return oddSum;
        }
    }
}
