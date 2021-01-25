using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int totalAnswerForHour = firstEmployee + secondEmployee + thirdEmployee;
            int hourCount = 0;
            while (peopleCount > 0)
            {

                hourCount++;
                if (hourCount % 4 == 0)
                {
                    continue;
                }
                peopleCount -= totalAnswerForHour;
            }
            Console.WriteLine($"Time needed: {hourCount}h.");
        }
    }
}
