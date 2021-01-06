using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumSpice = 0;
            int yield = num;
            int dayCounter = 0;
            int totalAmount = 0;
            while (yield >= 100)
            {
                sumSpice += yield;
                sumSpice -= 26;
                yield -= 10;
                dayCounter++;
            }
            if (yield < 100)
            {
                if (sumSpice < 26)
                {
                    totalAmount = sumSpice;
                }
                else
                {
                    sumSpice -= 26;
                    totalAmount = sumSpice;
                }
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(totalAmount);
        }
    }
}
