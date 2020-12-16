using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int age = 17;
            double totalMoney = 0.0;
            for (int i = 1800; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    age++;
                    money -= 12000;
                    totalMoney = money;
                }
                if (i % 2 == 1)
                {
                    age++;
                    money -= 12000 + 50 * age;
                    totalMoney = money;
                }
            }
            if (totalMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {totalMoney:f2} dollars left.");
            }
            else if (totalMoney < 0)
            {
                totalMoney = Math.Abs(totalMoney);
                Console.WriteLine($"He will need {totalMoney:f2} dollars to survive.");
            }
        }
    }
}
