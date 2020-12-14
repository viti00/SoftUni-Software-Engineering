using System;

namespace _9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());
            double dayForPlay = 0.0;
            double totalDay = 0.0;
            double holiday = 0.0;
            double total = 0.0;
            if (year == "normal")
            {
                dayForPlay = 48 - h;
                totalDay = dayForPlay * 3 / 4;
                holiday = p * 2 / 3;
                total = totalDay + h + holiday;
                Console.WriteLine($"{Math.Floor(total)}");
            }
            else if (year == "leap")
            {
                dayForPlay = 48 - h;
                totalDay = dayForPlay * 3 / 4;
                holiday = p * 2 / 3;
                total = totalDay + h + holiday;
                double leapYear = total + (total * 0.15);
                Console.WriteLine($"{Math.Floor(leapYear)}");
            }
        }
    }
}
