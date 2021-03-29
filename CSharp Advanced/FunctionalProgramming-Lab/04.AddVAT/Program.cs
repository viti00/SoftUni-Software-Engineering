using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(decimal.Parse)
                .Select(x => x + (x * 0.2m))
                .Select(x => x = Math.Round(x, 2))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}
