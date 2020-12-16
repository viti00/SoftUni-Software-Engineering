using System;

namespace _09.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    string result = "";
                    result += $"{hour} : {min}";
                    Console.WriteLine(result);
                }
            }
        }
    }
}
