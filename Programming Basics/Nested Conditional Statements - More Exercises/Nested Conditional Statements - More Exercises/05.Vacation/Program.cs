using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destiny = "";
            string type = "";
            double price = 0.0;
            if (buget <= 1000)
            {
                type = "Camp";
                if (season == "Summer")
                {
                    destiny = "Alaska";
                    price = buget * 0.65;
                }
                else if (season == "Winter")
                {
                    destiny = "Morocco";
                    price = buget * 0.45;
                }
            }
            else if (buget > 1000 && buget <= 3000)
            {
                type = "Hut";
                if (season == "Summer")
                {
                    destiny = "Alaska";
                    price = buget * 0.8;
                }
                else if (season == "Winter")
                {
                    destiny = "Morocco";
                    price = buget * 0.6;
                }
            }
            else if (buget > 3000)
            {
                type = "Hotel";
                if (season == "Summer")
                {
                    destiny = "Alaska";
                    price = buget * 0.9;
                }
                else if (season == "Winter")
                {
                    destiny = "Morocco";
                    price = buget * 0.9;
                }
            }
            Console.WriteLine($"{destiny} - {type} - {price:F2}");
        }
    }
}
