using System;
using System.Diagnostics.Tracing;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            int position = 0;
            double totalResult = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                string curr = sequence[i];
                char firstLet = curr[0];
                char secondLet = curr[curr.Length - 1];

                double number = double.Parse(curr.Substring(1, curr.Length - 2));
                if (char.IsUpper(firstLet))
                {
                    position = (int)firstLet - 64;
                    result = number / position;
                }
                else
                {
                    position = (int)firstLet - 96;
                    result = number * position;
                }


                if (char.IsUpper(secondLet))
                {
                    position = (int)secondLet - 64;
                    result -= position;
                }
                else
                {
                    position = (int)secondLet - 96;
                    result += position;
                }

                totalResult += result;
                result = 0;
            }
            Console.WriteLine($"{totalResult:f2}");
        }
    }
}
