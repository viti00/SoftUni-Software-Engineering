using System;

namespace _08.FuelTank_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();
            //fuels price
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            // fuels name
            string fuel1 = "Gasoline";
            string fuel2 = "Diesel";
            string fuel3 = "Gas";
            double finalPrice = 0.0;
            if (discountCard == "Yes")
            {
                if (fuel == fuel1)
                {
                    double gasolinePriceAfterDiscount = gasoline - 0.18;
                    finalPrice = amount * gasolinePriceAfterDiscount;
                }
                else if (fuel == fuel2)
                {
                    double dieselPriceAfterDiscount = diesel - 0.12;
                    finalPrice = amount * dieselPriceAfterDiscount;
                }
                else if (fuel == fuel3)
                {
                    double gasPriceAfterDiscount = gas - 0.08;
                    finalPrice = amount * gasPriceAfterDiscount;
                }
            }
            else if (discountCard == "No")
            {
                if (fuel == fuel1)
                {
                    finalPrice = amount * gasoline;
                }
                else if (fuel == fuel2)
                {
                    finalPrice = amount * diesel;
                }
                else if (fuel == fuel3)
                {
                    finalPrice = amount * gas;
                }
            }
            double totalPrice = 0.0;
            if (amount >= 20 && amount <= 25)
            {
                totalPrice = finalPrice - (finalPrice * 0.08);
            }
            else if (amount > 25)
            {
                totalPrice = finalPrice - (finalPrice * 0.1);
            }
            else
            {
                totalPrice = finalPrice;
            }
            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
