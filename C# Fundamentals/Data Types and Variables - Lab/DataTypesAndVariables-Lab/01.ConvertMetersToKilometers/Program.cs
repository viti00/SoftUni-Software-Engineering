using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal metres = decimal.Parse(Console.ReadLine());
            decimal kilometres = metres / 1000;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
