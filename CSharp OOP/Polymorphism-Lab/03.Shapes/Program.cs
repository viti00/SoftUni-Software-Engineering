using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(2, 5);
            Shape circle = new Circle(4);

            Console.WriteLine(rect.CalculatePerimeter());
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.Draw());

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.Draw());
        }
    }
}
