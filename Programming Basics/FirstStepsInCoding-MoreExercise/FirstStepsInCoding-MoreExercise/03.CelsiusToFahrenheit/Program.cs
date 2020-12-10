using System;

namespace _03.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double celsiusToFahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{celsiusToFahrenheit:F2}");
        }
    }
}
