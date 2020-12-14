using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            double roomForOnePerson = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;
            double nights = days - 1;
            double price = 0.0;
            double totalPrice = 0.0;
            if (nights < 10 && grade == "positive")
            {
                if (room == "room for one person")
                {
                    price = nights * roomForOnePerson;
                    totalPrice = price + (price * 0.25);
                }
                else if (room == "apartment")
                {
                    price = nights * apartment - (nights * apartment) * 0.30;
                    totalPrice = price + (price * 0.25);
                }
                else if (room == "president apartment")
                {
                    price = nights * presidentApartment - (nights * presidentApartment) * 0.1;
                    totalPrice = price + (price * 0.25);
                }
            }
            else if (nights >= 10 && nights <= 15 && grade == "positive")
            {
                if (room == "room for one person")
                {
                    price = nights * roomForOnePerson;
                    totalPrice = price + (price * 0.25);
                }
                else if (room == "apartment")
                {
                    price = nights * apartment - (nights * apartment) * 0.35;
                    totalPrice = price + (price * 0.25);
                }
                else if (room == "president apartment")
                {
                    price = nights * presidentApartment - (nights * presidentApartment) * 0.15;
                    totalPrice = price + (price * 0.25);
                }
            }
            else if (nights > 15 && grade == "positive")
            {
                if (room == "room for one person")
                {
                    price = nights * roomForOnePerson;
                    totalPrice = price + (price * 0.25);
                }
                else if (room == "apartment")
                {
                    price = nights * apartment - (nights * apartment) * 0.50;
                    totalPrice = price + (price * 0.25);
                }
                else if (room == "president apartment")
                {
                    price = nights * presidentApartment - (nights * presidentApartment) * 0.20;
                    totalPrice = price + (price * 0.25);
                }
            }
            else if (nights < 10 && grade == "negative")
            {
                if (room == "room for one person")
                {
                    price = nights * roomForOnePerson;
                    totalPrice = price - (price * 0.1);
                }
                else if (room == "apartment")
                {
                    price = nights * apartment - (nights * apartment) * 0.30;
                    totalPrice = price - (price * 0.1);
                }
                else if (room == "president apartment")
                {
                    price = nights * presidentApartment - (nights * presidentApartment) * 0.1;
                    totalPrice = price - (price * 0.1);
                }
            }
            else if (nights >= 10 && nights <= 15 && grade == "negative")
            {
                if (room == "room for one person")
                {
                    price = nights * roomForOnePerson;
                    totalPrice = price - (price * 0.1);
                }
                else if (room == "apartment")
                {
                    price = nights * apartment - (nights * apartment) * 0.35;
                    totalPrice = price - (price * 0.1);
                }
                else if (room == "president apartment")
                {
                    price = nights * presidentApartment - (nights * presidentApartment) * 0.15;
                    totalPrice = price - (price * 0.1);
                }
            }
            else if (nights > 15 && grade == "negative")
            {
                if (room == "room for one person")
                {
                    price = nights * roomForOnePerson;
                    totalPrice = price - (price * 0.1);
                }
                else if (room == "apartment")
                {
                    price = nights * apartment - (nights * apartment) * 0.50;
                    totalPrice = price - (price * 0.1);
                }
                else if (room == "president apartment")
                {
                    price = nights * presidentApartment - (nights * presidentApartment) * 0.20;
                    totalPrice = price - (price * 0.1);
                }
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
