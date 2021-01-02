using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nSum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);
                nSum += 2 * i - 1;
            }
            Console.WriteLine("Sum: {0}", nSum);
        }
    }
}
