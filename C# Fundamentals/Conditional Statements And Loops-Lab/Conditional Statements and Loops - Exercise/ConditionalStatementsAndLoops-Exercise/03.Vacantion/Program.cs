using System;

namespace _03.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            double discount = 0.0;
            double totalPrice = 0.0;
            switch (groupType)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = group * 8.45;
                            if (group >= 30)
                            {
                                discount = price * 0.15;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                        case "Saturday":
                            price = group * 9.80;
                            if (group >= 30)
                            {
                                discount = price * 0.15;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                        case "Sunday":
                            price = group * 10.46;
                            if (group >= 30)
                            {
                                discount = price * 0.15;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = group * 10.90;
                            if (group >= 100)
                            {
                                discount = 10 * 10.90;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                        case "Saturday":
                            price = group * 15.60;
                            if (group >= 100)
                            {
                                discount = 10 * 15.60;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                        case "Sunday":
                            price = group * 16;
                            if (group >= 100)
                            {
                                discount = 10 * 16;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = group * 15;
                            if (group >= 10 && group <= 20)
                            {
                                discount = price * 0.05;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                        case "Saturday":
                            price = group * 20;
                            if (group >= 10 && group <= 20)
                            {
                                discount = price * 0.05;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                        case "Sunday":
                            price = group * 22.50;
                            if (group >= 10 && group <= 20)
                            {
                                discount = price * 0.05;
                                totalPrice = price - discount;
                            }
                            else
                            {
                                totalPrice = price;
                            }
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
