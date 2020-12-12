using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * (r * r);
            }
            else if (shape == "triangle")
            {
                double x = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = x * h / 2;
            }
            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
