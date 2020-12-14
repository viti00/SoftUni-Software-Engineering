using System;

namespace _10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            while (n >= 0)
            {
                double multiplyBy2 = n * 2;
                Console.WriteLine($"Result: {multiplyBy2:F2}");
                n = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
