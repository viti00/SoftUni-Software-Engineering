using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int buged = int.Parse(Console.ReadLine());
            double price = 0.0;
            double totalPrice = 0.0;
            string output = "";
            if (flowers == "Roses")
            {
                if (count > 80)
                {
                    price = count * 5;
                    totalPrice = price - (price * 0.1);
                }
                else
                {
                    totalPrice = count * 5;
                }
            }
            else if (flowers == "Dahlias")
            {
                if (count > 90)
                {
                    price = count * 3.80;
                    totalPrice = price - (price * 0.15);
                }
                else
                {
                    totalPrice = count * 3.80;
                }
            }
            else if (flowers == "Tulips")
            {
                if (count > 80)
                {
                    price = count * 2.80;
                    totalPrice = price - (price * 0.15);
                }
                else
                {
                    totalPrice = count * 2.80;
                }
            }
            else if (flowers == "Narcissus")
            {
                if (count < 120)
                {
                    price = count * 3;
                    totalPrice = price + (price * 0.15);
                }
                else
                {
                    totalPrice = count * 3;
                }
            }
            else if (flowers == "Gladiolus")
            {
                if (count < 80)
                {
                    price = count * 2.50;
                    totalPrice = price + (price * 0.2);
                }
                else
                {
                    totalPrice = count * 2.50;
                }
            }
            double more = 0.0;
            double needed = 0.0;
            if (buged >= totalPrice)
            {
                more = buged - totalPrice;
                output = $"Hey, you have a great garden with {count} {flowers} and {more:F2} leva left.";
            }
            else if (buged < totalPrice)
            {
                needed = totalPrice - buged;
                output = $"Not enough money, you need {needed:F2} leva more.";
            }
            Console.WriteLine(output);
        }
    }
}
