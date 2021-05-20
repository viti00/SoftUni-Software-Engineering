using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IBirthable> all = new List<IBirthable>();

            while(input != "End")
            {
                string[] splitted = input.Split();

                if (splitted[0] == "Citizen")
                {
                    all.Add(new Citizen(splitted[1], int.Parse(splitted[2]), splitted[3], splitted[4]));
                }
                else if (splitted[0] == "Pet")
                {
                    all.Add(new Pet(splitted[1], splitted[2]));
                }
                else if (splitted[0] == "Robot")
                {
                    
                }

                input = Console.ReadLine();
            }

            string specificYear = Console.ReadLine();

            all.Where(c => c.Birthdate.EndsWith(specificYear))
                .Select(c => c.Birthdate)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
