using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int validOperation = 0;
            for (int x1 = 0; x1 <= input; x1++)
            {
                for (int x2 = 0; x2 <= input; x2++)
                {
                    for (int x3 = 0; x3 <= input; x3++)
                    {
                        int product = x1 + x2 + x3;
                        if (product == input)
                        {
                            validOperation++;
                        }
                    }
                }
            }
            Console.WriteLine(validOperation);
        }
    }
}
