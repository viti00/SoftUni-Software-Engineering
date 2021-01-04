using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int total = 0;
            foreach (char ch in num)
            {
                int number = ch - 48;
                int factorial = 1;
                for (var j = 1; j <= number; j++)
                {
                    factorial *= j;
                }
                total += factorial;
            }
            int stringToNum = int.Parse(num);
            if (stringToNum == total)
            {
                Console.WriteLine("yes");
            }
            else if (stringToNum != total)
            {
                Console.WriteLine("no");
            }
        }
    }
}
