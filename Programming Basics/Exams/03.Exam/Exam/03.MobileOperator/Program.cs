using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string contract = Console.ReadLine();
            string mobileNetwork = Console.ReadLine();
            int mounthCount = int.Parse(Console.ReadLine());
            double taxe = 0;
            switch (term)
            {
                case "one":
                    switch (contract)
                    {
                        case "Small":
                            taxe = 9.98;
                            break;
                        case "Middle":
                            taxe = 18.99;
                            break;
                        case "Large":
                            taxe = 25.98;
                            break;
                        case "ExtraLarge":
                            taxe = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (contract)
                    {
                        case "Small":
                            taxe = 8.58;
                            break;
                        case "Middle":
                            taxe = 17.09;
                            break;
                        case "Large":
                            taxe = 23.59;
                            break;
                        case "ExtraLarge":
                            taxe = 31.79;
                            break;
                    }
                    break;
            }
            double totalPrice = 0;
            switch (mobileNetwork)
            {
                case "yes":
                    if (taxe <= 10.00)
                    {
                        totalPrice = (taxe + 5.50) * mounthCount;
                    }
                    else if (taxe > 10.00 && taxe <= 30.00)
                    {
                        totalPrice = (taxe + 4.35) * mounthCount;
                    }
                    else if (taxe > 30.00)
                    {
                        totalPrice = (taxe + 3.85) * mounthCount;
                    }
                    break;
                case "no":
                    totalPrice = taxe * mounthCount;
                    break;
            }
            double finalPrice = 0;
            if (term == "two")
            {
                finalPrice = totalPrice - totalPrice * 0.0375;
            }
            else
            {
                finalPrice = totalPrice;
            }
            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}
