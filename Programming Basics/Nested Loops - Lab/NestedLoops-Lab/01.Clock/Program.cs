using System;

namespace _01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    string result = "";
                    result = $"{hours}:{min}";
                    Console.WriteLine(result);
                }
            }
        }
    }
}
