using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double workDays = days - days * 0.1;
            double workHours = workDays * 8;
            double overWork = workers * (2 * days);
            double totalHours = workHours + overWork;
            string output = "";
            if (hours <= totalHours)
            {
                double ostavashti = totalHours - hours;
                output = $"Yes!{Math.Floor(ostavashti)} hours left.";
            }
            else
            {
                double nedostigashti = hours - totalHours;
                output = $"Not enough time!{(double)Math.Ceiling(nedostigashti)} hours needed.";
            }
            Console.WriteLine(output);
        }
    }
}
