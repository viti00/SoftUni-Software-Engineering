using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60)
            {
                minutes = minutes - 60;
                hours += 1;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            string output = "";
            if (minutes < 10)
            {
                output = ($"{hours}:0{minutes}");
            }
            else
            {
                output = ($"{hours}:{minutes}");
            }


            Console.WriteLine(output);
        }
    }
}
