using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int sum = firstNum + secondNum;
            double divide = sum / thirdNum;
            double multiply = divide * fourthNum;
            Console.WriteLine(multiply);
        }
    }
}
