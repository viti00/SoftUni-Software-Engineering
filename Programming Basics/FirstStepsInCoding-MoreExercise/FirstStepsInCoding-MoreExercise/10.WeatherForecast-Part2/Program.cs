using System;

namespace _10.WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreses = double.Parse(Console.ReadLine());
            if (degreses < 5.00)
            {
                Console.WriteLine("unknown");
            }
            else if (degreses <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (degreses <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degreses <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degreses <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degreses <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degreses > 35)
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
