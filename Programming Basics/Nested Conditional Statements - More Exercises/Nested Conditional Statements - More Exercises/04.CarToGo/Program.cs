using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classType = "";
            string type = "";
            double price = 0.0;
            if (buget <= 100)
            {
                classType = "Economy class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = buget * 0.35;
                }
                else if (season == "Winter")
                {
                    type = "Jeep";
                    price = buget * 0.65;
                }
            }
            else if (buget > 100 && buget <= 500)
            {
                classType = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = buget * 0.45;
                }
                else if (season == "Winter")
                {
                    type = "Jeep";
                    price = buget * 0.8;
                }
            }
            else if (buget > 500)
            {
                classType = "Luxury class";
                type = "Jeep";
                price = buget * 0.9;
            }
            Console.WriteLine($"{classType}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
