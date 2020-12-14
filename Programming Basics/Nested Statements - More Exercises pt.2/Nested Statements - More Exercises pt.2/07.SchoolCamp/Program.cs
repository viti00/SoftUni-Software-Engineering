using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            double price1 = 0.0;
            string output = "";
            double priceAfterDiscount = 0.0;
            switch (season)
            {
                case "Spring":
                    if (groupType == "boys")
                    {
                        output = "Tennis";
                        price = nights * 7.20 * students;
                        price1 = price;
                    }
                    else if (groupType == "girls")
                    {
                        output = "Athletics";
                        price = nights * 7.20 * students;
                        price1 = price;
                    }
                    else if (groupType == "mixed")
                    {
                        output = "Cycling";
                        price = nights * 9.50 * students;
                        price1 = price;
                    }
                    break;
                case "Summer":
                    if (groupType == "boys")
                    {
                        output = "Football";
                        price = nights * 15 * students;
                        price1 = price;
                    }
                    else if (groupType == "girls")
                    {
                        output = "Volleyball";
                        price = nights * 15 * students;
                        price1 = price;
                    }
                    else if (groupType == "mixed")
                    {
                        output = "Swimming";
                        price = nights * 20 * students;
                        price1 = price;
                    }
                    break;
                case "Winter":
                    if (groupType == "boys")
                    {
                        output = "Judo";
                        price = nights * 9.60 * students;
                        price1 = price;
                    }
                    else if (groupType == "girls")
                    {
                        output = "Gymnastics";
                        price = nights * 9.60 * students;
                        price1 = price;
                    }
                    else if (groupType == "mixed")
                    {
                        output = "Ski";
                        price = nights * 10 * students;
                        price1 = price;
                    }
                    break;
            }
            if (students >= 10 && students < 20)
            {
                priceAfterDiscount = price1 - (price1 * 0.05);
                price = priceAfterDiscount;
            }
            else if (students >= 20 && students < 50)
            {
                priceAfterDiscount = price1 - (price1 * 0.15);
                price = priceAfterDiscount;
            }
            else if (students >= 50)
            {
                priceAfterDiscount = price1 - (price1 * 0.5);
                price = priceAfterDiscount;
            }
            Console.WriteLine($"{output} {price:F2} lv.");
        }
    }
}
