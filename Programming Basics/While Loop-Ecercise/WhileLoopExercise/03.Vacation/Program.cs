using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int dayscounter = 0;
            int spendingcounter = 0;
            while (ownedMoney < holidayPrice && spendingcounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayscounter++;
                if (command == "save")
                {
                    ownedMoney += money;
                    spendingcounter = 0;
                }
                else if (command == "spend")
                {
                    ownedMoney -= money;
                    spendingcounter++;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
            }
            if (spendingcounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(dayscounter);
            }
            if (ownedMoney >= holidayPrice)
            {
                Console.WriteLine($"You saved the money for {dayscounter} days.");
            }
        }
    }
}
