using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int afrer30Min = minutes + 30;
            if (afrer30Min > 59)
            {
                hours++;
                minutes = afrer30Min - 60;
            }
            else
            {
                minutes = afrer30Min;
            }
            if (hours > 23)
            {
                hours = 24 - hours;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
