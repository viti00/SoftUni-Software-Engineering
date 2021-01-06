using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumValue = 0;
            for (int i = 1; i <= n; i++)
            {
                char value = char.Parse(Console.ReadLine());
                int charValue = Convert.ToInt16(value);
                sumValue += charValue;
            }
            Console.WriteLine($"The sum equals: {sumValue}");
        }
    }
}
