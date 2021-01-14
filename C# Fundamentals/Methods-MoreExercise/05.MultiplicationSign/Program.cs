using System;
using System.Collections.Generic;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double seconfNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            CheckNumbers(firstNum, seconfNum, thirdNum);
        }
        static void CheckNumbers(double first, double second, double third)
        {
            int negativeCounter = 0;
            int positiveCounter = 0;
            int zeroCounter = 0;
            List<double> checkNumbers = new List<double>();
            checkNumbers.Add(first);
            checkNumbers.Add(second);
            checkNumbers.Add(third);
            foreach (var item in checkNumbers)
            {
                if (item < 0)
                {
                    negativeCounter++;
                }
                else if (item == 0)
                {
                    zeroCounter++;
                }
                else
                {
                    positiveCounter++;
                }
            }
            CheckResult(negativeCounter, positiveCounter, zeroCounter);
        }
        static void CheckResult(int negative, int positive, int zero)
        {
            if (zero > 0)
            {
                Console.WriteLine("zero");
            }
            if (negative % 2 == 0 && zero == 0 && positive > 0)
            {
                Console.WriteLine("positive");
            }
            if (negative % 2 == 1 && zero == 0)
            {
                Console.WriteLine("negative");
            }
        }
    }
}
