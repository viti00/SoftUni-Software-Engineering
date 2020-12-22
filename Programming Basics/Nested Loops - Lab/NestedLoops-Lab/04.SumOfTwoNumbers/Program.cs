using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int exit = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool combinationFound = false;
            for (int i = start; i <= exit; i++)
            {
                for (int j = start; j <= exit; j++)
                {
                    combinationCounter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNumber})");
                        combinationFound = true;
                        break;
                    }
                }
                if (combinationFound)
                {
                    break;
                }
            }
            if (!combinationFound)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
