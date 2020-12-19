using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dupf = n;
            double sum = 0;

            while (dupf != 0)
            {
                dupf = dupf - 1;
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{ sum / n:F2}");
        }
    }
}
