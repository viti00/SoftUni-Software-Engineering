using System;
using System.Collections.Generic;

namespace _1.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
                { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events =
                { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors =
                { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 1; i <= n; i++)
            {
                int randomPhrases = rnd.Next(0, phrases.Length);
                int randomEvents = rnd.Next(0, events.Length);
                int randomAuthors = rnd.Next(0, authors.Length);
                int randomCities = rnd.Next(0, cities.Length);
                Console.WriteLine($"{phrases[randomPhrases]} {events[randomEvents]} {authors[randomAuthors]} - {cities[randomCities]}.");
            }

        }
    }
}
