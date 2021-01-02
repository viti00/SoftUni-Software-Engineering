using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            if (num % 2 == 0)
            {
                if (num < 0)
                {
                    int num2 = num * (-1);
                    Console.WriteLine($"The number is: {num2}");
                }
                else
                {
                    Console.WriteLine($"The number is: {num}");
                }
            }
        }
    }
}
