using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintArea(width, height));
        }
        static double PrintArea(double x, double y)
        {
            return x * y;
        }
    }
}
