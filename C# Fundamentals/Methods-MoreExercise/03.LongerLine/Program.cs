using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if ((Math.Abs(x1) + Math.Abs(y1)) + (Math.Abs(x2) + Math.Abs(y2)) < (Math.Abs(x3) + Math.Abs(y3)) + (Math.Abs(x4) + Math.Abs(y4)))
            {
                Console.WriteLine(CheckClosestPointToCenter(x3, y3, x4, y4));
            }
            else if ((Math.Abs(x1) + Math.Abs(y1)) + (Math.Abs(x2) + Math.Abs(y2)) > (Math.Abs(x3) + Math.Abs(y3)) + (Math.Abs(x4) + Math.Abs(y4)))
            {
                Console.WriteLine(CheckClosestPointToCenter(x1, y1, x2, y2));
            }
            else
            {
                Console.WriteLine(CheckClosestPointToCenter(x1, y1, x2, y2));
            }
        }
        static string CheckClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            double firstXCordinate = 0;
            double firstYCordinate = 0;
            double seconXCordinate = 0;
            double secondYCordinate = 0;
            string result = "";
            if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
            {
                firstXCordinate = x1;
                firstYCordinate = y1;
                seconXCordinate = x2;
                secondYCordinate = y2;
                result = $"({firstXCordinate.ToString()}, {firstYCordinate.ToString()})({seconXCordinate.ToString()}, {secondYCordinate.ToString()})";
                return result;
            }
            else if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
            {
                firstXCordinate = x2;
                firstYCordinate = y2;
                seconXCordinate = x1;
                secondYCordinate = y1;
                result = $"({firstXCordinate.ToString()}, {firstYCordinate.ToString()})({seconXCordinate.ToString()}, {secondYCordinate.ToString()})";
                return result;
            }
            else
            {
                firstXCordinate = x1;
                firstYCordinate = y1;
                seconXCordinate = x2;
                secondYCordinate = y2;
                result = $"({firstXCordinate.ToString()}, {firstYCordinate.ToString()})({seconXCordinate.ToString()}, {secondYCordinate.ToString()})";
                return result;
            }
        }
    }
}
