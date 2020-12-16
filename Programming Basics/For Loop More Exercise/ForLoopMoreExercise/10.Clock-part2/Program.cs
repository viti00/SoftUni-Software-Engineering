using System;

namespace _10.Clock_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        string result = "";
                        result += $"{hour} : {min} : {sec}";
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
