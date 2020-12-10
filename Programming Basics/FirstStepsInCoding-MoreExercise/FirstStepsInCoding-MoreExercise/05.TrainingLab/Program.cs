using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            //calculation
            double lenghtInCm = lenght * 100;
            double widhtInCm = width * 100;
            double free = widhtInCm - 100;
            double rols = Math.Truncate(free / 70);
            double cols = Math.Truncate(lenghtInCm / 120);
            double seats = rols * cols - 3;
            Console.WriteLine(seats);
        }
    }
}
