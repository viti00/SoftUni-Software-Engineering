using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;
            while (input != "Stop")
            {
                int nums = int.Parse(input);
                if (nums < min)
                {
                    min = nums;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
