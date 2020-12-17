using System;

namespace _03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;
            int numSum = 0;
            while (k <= number)
            {
                int nums = int.Parse(Console.ReadLine());
                numSum += nums;
                if (numSum >= number)
                {
                    Console.WriteLine(numSum);
                    break;
                }
            }
        }
    }
}
