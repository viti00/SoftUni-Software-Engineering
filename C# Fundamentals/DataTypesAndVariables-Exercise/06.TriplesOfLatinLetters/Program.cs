using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97 + n; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int g = 97; g < 97 + n; g++)
                    {
                        Console.WriteLine($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(g)}");
                    }
                }
            }
        }
    }
}
