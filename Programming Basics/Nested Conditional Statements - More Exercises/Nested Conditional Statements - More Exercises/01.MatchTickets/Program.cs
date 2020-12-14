using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int peoples = int.Parse(Console.ReadLine());
            double bugetLeft = 0.0;

            if (peoples >= 1 && peoples <= 4)
            {
                bugetLeft = buget - (buget * 0.75);
            }
            else if (peoples >= 5 && peoples <= 9)
            {
                bugetLeft = buget - (buget * 0.60);
            }
            else if (peoples >= 10 && peoples <= 24)
            {
                bugetLeft = buget - (buget * 0.50);
            }
            else if (peoples >= 25 && peoples <= 49)
            {
                bugetLeft = buget - (buget * 0.40);
            }
            else if (peoples >= 50)
            {
                bugetLeft = buget - (buget * 0.25);
            }

            double ostavashti = 0.0;
            double nedostigashti = 0.0;
            double normalTicket = peoples * 249.99;
            double vipTicket = peoples * 499.99;

            if (type == "Normal")
            {
                if (bugetLeft > normalTicket)
                {
                    ostavashti = bugetLeft - normalTicket;
                    Console.WriteLine($"Yes! You have {ostavashti:F2} leva left.");
                }
                else
                {
                    nedostigashti = normalTicket - bugetLeft;
                    Console.WriteLine($"Not enough money! You need {nedostigashti:F2} leva.");
                }
            }
            else if (type == "VIP")
            {
                if (bugetLeft > vipTicket)
                {
                    ostavashti = bugetLeft - vipTicket;
                    Console.WriteLine($"Yes! You have {ostavashti:F2} leva left.");
                }
                else
                {
                    nedostigashti = vipTicket - bugetLeft;
                    Console.WriteLine($"Not enough money! You need {nedostigashti:F2} leva.");
                }
            }
        }
    }
}
