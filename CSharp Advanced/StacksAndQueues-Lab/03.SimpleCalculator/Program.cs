using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> calculation = new Stack<string>(input.Reverse());


            while (calculation.Count != 1)
            {
                int firstNum = int.Parse(calculation.Pop());
                string sign = calculation.Pop();
                int secondNum = int.Parse(calculation.Pop());
                if (sign == "+")
                {
                    int sum = firstNum + secondNum;
                    calculation.Push(sum.ToString());
                }
                else if (sign == "-")
                {
                    int substact = firstNum - secondNum;
                    calculation.Push(substact.ToString());
                }
            }
            Console.WriteLine(calculation.Pop());
        }
    }
}
