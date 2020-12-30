using System;

namespace _03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();
            double joineryPrice = 0.0;
            double joineryPriceAfterDiscount = 0.0;
            double joineryPriceWithDelivery = 0.0;
            double finalPrice = 0.0;
            if (joineryCount <= 10)
            {
                Console.WriteLine("Invalid order");
            }
            if (type == "90X130" && joineryCount > 10)
            {
                joineryPrice = joineryCount * 110;
                if (joineryCount > 30 && joineryCount <= 60)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.05);
                }
                else if (joineryCount > 60)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.08);
                }
                else
                {
                    joineryPriceAfterDiscount = joineryPrice;
                }
                if (delivery == "With delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount + 60;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
                else if (delivery == "Without delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
            }
            else if (type == "100X150" && joineryCount > 10)
            {
                joineryPrice = joineryCount * 140;
                if (joineryCount > 40 && joineryCount <= 80)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.06);
                }
                else if (joineryCount > 80)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.1);
                }
                else
                {
                    joineryPriceAfterDiscount = joineryPrice;
                }
                if (delivery == "With delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount + 60;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
                else if (delivery == "Without delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
            }
            else if (type == "130X180" && joineryCount > 10)
            {
                joineryPrice = joineryCount * 190;
                if (joineryCount > 20 && joineryCount <= 50)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.07);
                }
                else if (joineryCount > 50)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.12);
                }
                else
                {
                    joineryPriceAfterDiscount = joineryPrice;
                }
                if (delivery == "With delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount + 60;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
                else if (delivery == "Without delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
            }
            else if (type == "200X300" && joineryCount > 10)
            {
                joineryPrice = joineryCount * 250;
                if (joineryCount > 25 && joineryCount <= 50)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.09);
                }
                else if (joineryCount > 50)
                {
                    joineryPriceAfterDiscount = joineryPrice - (joineryPrice * 0.14);
                }
                else
                {
                    joineryPriceAfterDiscount = joineryPrice;
                }
                if (delivery == "With delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount + 60;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
                else if (delivery == "Without delivery")
                {
                    joineryPriceWithDelivery = joineryPriceAfterDiscount;
                    if (joineryCount > 99)
                    {
                        finalPrice = joineryPriceWithDelivery - (joineryPriceWithDelivery * 0.04);
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                    else
                    {
                        finalPrice = joineryPriceWithDelivery;
                        Console.WriteLine($"{finalPrice:f2} BGN");
                    }
                }
            }
        }
    }
}
