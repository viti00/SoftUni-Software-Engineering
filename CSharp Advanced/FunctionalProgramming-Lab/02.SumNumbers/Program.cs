using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSumAndCount(
                int.Parse,
                a => a.Length,
                number =>
                {
                    int sum = 0;
                    sum = number.Sum();
                    return sum;
                });


        }
        static void PrintSumAndCount(Func<string, int> parser,
            Func<int[], int> getCount,
            Func<int[], int> getSum)
        {


            int[] numbers = Console.ReadLine()
                 .Split(", ")
                 .Select(parser)
                 .ToArray();


            Console.WriteLine(getCount(numbers));
            Console.WriteLine(getSum(numbers));

        }
    }
}
