using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> printer = GetMinValue;
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(printer(numbers));

        }
        static int GetMinValue(int[] numbers)
        {
            int min = int.MaxValue;
            if (numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int curNum = numbers[i];
                    if (curNum < min)
                    {
                        min = curNum;
                    }
                }
            }
            return min;
        }
    }
}
