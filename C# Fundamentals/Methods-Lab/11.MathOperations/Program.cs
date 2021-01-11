using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            double result = Calculator(num1, @operator, num2);
            Console.WriteLine(Math.Round(result, 2));
        }
        static double Calculator(double num1, string @operator, double num2)
        {
            double result = 0;
            switch (@operator)
            {
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
            }
            return result;
        }
    }
}
