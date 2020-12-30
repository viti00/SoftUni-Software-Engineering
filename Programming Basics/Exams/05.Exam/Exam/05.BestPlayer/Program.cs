using System;

namespace _05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int max = int.MinValue;
            string bestPlayer = "";
            while (name != "END")
            {
                int goalCount = int.Parse(Console.ReadLine());
                if (goalCount > max)
                {
                    max = goalCount;
                    bestPlayer = name;
                }
                if (goalCount >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (max >= 3)
            {
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {max} goals.");
            }
        }
    }
}
