using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double n3 = 0.0;
            string output = "";
            string output1 = "";
            if (symbol == "+")
            {
                n3 = n1 + n2;
                if (n3 % 2 == 0)
                {
                    output1 = "even";
                    output = $"{n1} {symbol} {n2} = {n3} - {output1}";
                }
                else
                {
                    output1 = "odd";
                    output = $"{n1} {symbol} {n2} = {n3} - {output1}";
                }
            }
            else if (symbol == "-")
            {
                n3 = n1 - n2;
                if (n3 % 2 == 0)
                {
                    output1 = "even";
                    output = $"{n1} {symbol} {n2} = {n3} - {output1}";
                }
                else
                {
                    output1 = "odd";
                    output = $"{n1} {symbol} {n2} = {n3} - {output1}";
                }
            }
            else if (symbol == "*")
            {
                n3 = n1 * n2;
                if (n3 % 2 == 0)
                {
                    output1 = "even";
                    output = $"{n1} {symbol} {n2} = {n3} - {output1}";
                }
                else
                {
                    output1 = "odd";
                    output = $"{n1} {symbol} {n2} = {n3} - {output1}";
                }
            }
            else if (symbol == "/")
            {
                n3 = n1 / n2;
                if (n2 != 0)
                {
                    output = $"{n1} / {n2} = {n3:F2}";
                }
                else
                {
                    output = $"Cannot divide {n1} by zero";
                }
            }
            else if (symbol == "%")
            {
                n3 = n1 % n2;
                if (n2 != 0)
                {
                    output = $"{n1} % {n2} = {n3}";
                }
                else
                {
                    output = $"Cannot divide {n1} by zero";
                }
            }
            Console.WriteLine(output);
        }
    }
}
