using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            var meter = 0.0;

            if (from == "m")
            {
                meter = sum;
            }
            else if (from == "mm")
            {
                meter = sum / 1000;
            }
            else if (from == "cm")
            {
                meter = sum / 100;
            }
            else if (from == "mi")
            {
                meter = sum / 0.000621371192;
            }
            else if (from == "in")
            {
                meter = sum / 39.3700787;
            }
            else if (from == "km")
            {
                meter = sum / 0.001;
            }
            else if (from == "ft")
            {
                meter = sum / 3.2808399;
            }
            else if (from == "yd")
            {
                meter = sum / 1.0936133;
            }


            if (to == "m")
            {
                meter = meter * 1;
            }
            else if (to == "mm")
            {
                meter = meter * 1000;
            }
            else if (to == "cm")
            {
                meter = meter * 100;
            }
            else if (to == "mi")
            {
                meter = meter * 0.000621371192;
            }
            else if (to == "in")
            {
                meter = meter * 39.3700787;
            }
            else if (to == "km")
            {
                meter = meter * 0.001;
            }
            else if (to == "ft")
            {
                meter = meter * 3.2808399;
            }
            else if (to == "yd")
            {
                meter = meter * 1.0936133;
            }

            Console.WriteLine(string.Format("{0:F3}", meter));
        }
    }
}
