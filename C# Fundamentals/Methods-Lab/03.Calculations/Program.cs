using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            switch (command)
            {
                case "add":
                    PrintAdd(num1, num2);
                    break;
                case "multiply":
                    PrintMultiply(num1, num2);
                    break;
                case "subtract":
                    PrintSubtract(num1, num2);
                    break;
                case "divide":
                    PrintDivide(num1, num2);
                    break;
            }
        }
        static void PrintAdd(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void PrintMultiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void PrintSubtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void PrintDivide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
