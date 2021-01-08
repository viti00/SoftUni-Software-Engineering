using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int seconNumber = numbers[j];
                    if (firstNumber + seconNumber == num)
                    {
                        Console.WriteLine($"{firstNumber} {seconNumber}");
                        break;
                    }
                }
            }
        }
    }
}
