using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result = FactorialDevision(num1, num2);
            Console.WriteLine($"{result:f2}");
        }
        static double FactorialDevision(int num1, int num2)
        {
            double result = FactorialNum1Sum(num1) / FactorialNum2Sum(num2);
            return result;

        }
        static double FactorialNum1Sum(int num1)
        {
            double result = 1;
            while (num1 != 1)
            {
                result *= num1;
                num1 = num1 - 1;
            }
            return result;
        }
        static double FactorialNum2Sum(int num2)
        {
            double result = 1;
            while (num2 != 1)
            {
                result *= num2;
                num2 = num2 - 1;
            }
            return result;
        }
    }
}
