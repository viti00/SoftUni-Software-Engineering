using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string tickets = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double output = 0.0;
            if (tickets == "Premiere")
            {
                output = colums * rows * 12.00;
            }
            else if (tickets == "Normal")
            {
                output = colums * rows * 7.50;
            }
            else if (tickets == "Discount")
            {
                output = colums * rows * 5.00;
            }
            Console.WriteLine($"{output:F2} leva");
        }
    }
}
