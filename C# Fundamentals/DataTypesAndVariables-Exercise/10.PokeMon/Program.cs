using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int absolutNvalue = N;
            int targetCounter = 0;
            int remained = 0;
            while (N >= M)
            {
                N -= M;
                remained = N;
                targetCounter++;
                if (remained == absolutNvalue * 0.5)
                {
                    if (Y > 0)
                    {
                        N /= Y;
                        remained = N;
                    }
                }
            }
            if (remained < M)
            {
                Console.WriteLine(remained);
                Console.WriteLine(targetCounter);
            }
        }
    }
}
