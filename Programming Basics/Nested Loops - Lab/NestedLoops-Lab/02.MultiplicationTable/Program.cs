using System;

namespace _02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 10; n++)
            {
                for (int m = 1; m <= 10; m++)
                {
                    int final = n * m;
                    string result = "";
                    result = $"{n} * {m} = {final}";
                    Console.WriteLine(result);
                }
            }
        }
    }
}
