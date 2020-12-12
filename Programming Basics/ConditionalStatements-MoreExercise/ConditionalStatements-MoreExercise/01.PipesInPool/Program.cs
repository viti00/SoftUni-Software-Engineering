using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());
            // v from two pipes in %
            double TotalVFrom2Pipes = P1 * N + P2 * N;
            // pipes in %
            if (TotalVFrom2Pipes <= V)
            {
                double TotalVFrom2PipesInPercent = TotalVFrom2Pipes / V * 100;
                double pipe1InPercent = P1 * N / TotalVFrom2Pipes * 100;
                double pipe2InPecent = P2 * N / TotalVFrom2Pipes * 100;
                Console.WriteLine($"The pool is {TotalVFrom2PipesInPercent:F2}% full. Pipe 1: {pipe1InPercent:F2}%. Pipe 2: {pipe2InPecent:F2}%.");
            }
            else
            {
                double more = TotalVFrom2Pipes - V;
                Console.WriteLine($"For {N} hours the pool overflows with {more:F2} liters.");
            }
        }
    }
}
