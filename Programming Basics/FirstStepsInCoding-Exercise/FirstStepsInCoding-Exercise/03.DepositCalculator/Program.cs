using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double interesPercent = double.Parse(Console.ReadLine());

            double interestForMonth = ((depositAmount * interesPercent * 0.01) / 12);
            double result = depositAmount + depositTerm * interestForMonth;
            Console.WriteLine(result);
        }
    }
}
