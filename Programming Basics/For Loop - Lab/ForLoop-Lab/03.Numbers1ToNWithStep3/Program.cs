using System;

namespace _03.Numbers1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int num = 1; num <= N; num += 3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
