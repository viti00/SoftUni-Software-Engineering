using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double wmPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double savedMoney = 0.0;
            double money = 0.0;
            double sum = 0.0;
            double moneyTotal = 0.0;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += 10;
                    money += sum - 1;
                    savedMoney = money;
                    moneyTotal = savedMoney;
                }
                else
                {
                    toys++;
                }
            }
            moneyTotal += toys * toysPrice;
            if (moneyTotal >= wmPrice)
            {
                double more = moneyTotal - wmPrice;
                Console.WriteLine($"Yes! {more:F2}");
            }
            else if (moneyTotal < wmPrice)
            {
                double needed = wmPrice - moneyTotal;
                Console.WriteLine($"No! {needed:F2}");
            }
        }
    }
}
