using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double reminder = double.Parse(Console.ReadLine());
            double lv = Math.Floor(reminder);
            double pennies = Math.Round((reminder - lv) * 100);
            double counter = 0.0;
            while (lv > 0)
            {
                if (lv >= 2)
                {
                    counter += 1;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    counter += 1;
                    lv -= 1;
                }
            }
            while (pennies > 0)
            {
                if (pennies >= 50)
                {
                    counter += 1;
                    pennies -= 50;
                }
                else if (pennies >= 20)
                {
                    counter += 1;
                    pennies -= 20;
                }
                else if (pennies >= 10)
                {
                    counter += 1;
                    pennies -= 10;
                }
                else if (pennies >= 05)
                {
                    counter += 1;
                    pennies -= 05;
                }
                else if (pennies >= 02)
                {
                    counter += 1;
                    pennies -= 02;
                }
                else if (pennies >= 01)
                {
                    counter += 1;
                    pennies -= 01;
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
