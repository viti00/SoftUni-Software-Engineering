using System;

namespace _04.NumbersDividedBy3WithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = 1;
            while (startNum <= 100)
            {
                if (startNum % 3 == 0)
                {
                    Console.WriteLine(startNum);
                }
                startNum++;
            }
        }
    }
}
