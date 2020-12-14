using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double apartment = 0.0;
            double studio = 0.0;
            double studioPrice = 0.0;
            double apartmentPrice = 0.0;
            if (mounth == "May" || mounth == "October")
            {
                apartment = days * 65;
                apartmentPrice = apartment;
                studio = days * 50;
                studioPrice = studio;
                if (days > 14)
                {
                    studioPrice = studio - (studio * 0.30);
                }
                else if (days > 7)
                {
                    studioPrice = studio - (studio * 0.05);
                }
                else
                {
                    apartmentPrice = apartment;
                    studioPrice = studio;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                apartment = days * 68.70;
                apartmentPrice = apartment;
                studio = days * 75.20;
                studioPrice = studio;
                if (days > 14)
                {
                    studioPrice = studio - (studio * 0.20);
                }
                else
                {
                    studioPrice = studio;
                    apartmentPrice = apartment;
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                apartment = days * 77;
                apartmentPrice = apartment;
                studio = days * 76;
                studioPrice = studio;
            }
            if (days > 14)
            {
                apartmentPrice = apartment - (apartment * 0.1);
            }
            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
