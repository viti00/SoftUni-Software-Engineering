using System;

namespace _05.HoneyHervest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalHoney = 0.0;
            double finalHoney = 0.0;
            switch (season)
            {
                case "Spring":
                    switch (flower)
                    {
                        case "Sunflower":
                            totalHoney = count * 10;
                            finalHoney = totalHoney;
                            break;
                        case "Daisy":
                            totalHoney = count * 12;
                            finalHoney = totalHoney + (totalHoney * 0.1);
                            break;
                        case "Lavender":
                            totalHoney = count * 12;
                            finalHoney = totalHoney;
                            break;
                        case "Mint":
                            totalHoney = count * 10;
                            finalHoney = totalHoney + (totalHoney * 0.1);
                            break;
                    }
                    break;
                case "Summer":
                    switch (flower)
                    {
                        case "Sunflower":
                            totalHoney = count * 8;
                            finalHoney = totalHoney + (totalHoney * 0.1);
                            break;
                        case "Daisy":
                            totalHoney = count * 8;
                            finalHoney = totalHoney + (totalHoney * 0.1);
                            break;
                        case "Lavender":
                            totalHoney = count * 8;
                            finalHoney = totalHoney + (totalHoney * 0.1);
                            break;
                        case "Mint":
                            totalHoney = count * 12;
                            finalHoney = totalHoney + (totalHoney * 0.1);
                            break;
                    }
                    break;
                case "Autumn":
                    switch (flower)
                    {
                        case "Sunflower":
                            totalHoney = count * 12;
                            finalHoney = totalHoney - (totalHoney * 0.05);
                            break;
                        case "Daisy":
                            totalHoney = count * 6;
                            finalHoney = totalHoney - (totalHoney * 0.05);
                            break;
                        case "Lavender":
                            totalHoney = count * 6;
                            finalHoney = totalHoney - (totalHoney * 0.05);
                            break;
                        case "Mint":
                            totalHoney = count * 6;
                            finalHoney = totalHoney - (totalHoney * 0.05);
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Total honey harvested: {finalHoney:F2}");
        }
    }
}
