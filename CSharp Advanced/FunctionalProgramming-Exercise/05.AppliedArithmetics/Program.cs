using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            Action<List<int>> print =
                nums => Console.WriteLine(string.Join(" ", nums));

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int, int> function = GetArithmeticFunctio(command);
                    numbers = numbers.Select(function).ToList();
                }
            }
        }

        static Func<int, int> GetArithmeticFunctio(string command)
        {
            Func<int, int> arithmeticFunction = n => n;
            switch (command)
            {
                case "add":
                    return arithmeticFunction = n => n + 1;
                case "multiply":
                    return arithmeticFunction = n => n * 2;
                case "subtract":
                    return arithmeticFunction = n => n - 1;
                default:
                    return arithmeticFunction;
            }
        }
    }
}
