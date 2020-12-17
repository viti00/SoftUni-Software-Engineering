using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            while (input != "Stop")
            {
                int nums = int.Parse(input);
                if (nums > max)
                {
                    max = nums;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
