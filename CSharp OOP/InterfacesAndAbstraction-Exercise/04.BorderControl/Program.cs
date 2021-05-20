using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<IIdentifiable> all = new List<IIdentifiable>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitted = command.Split();

                if (splitted.Length == 3)
                {
                    all.Add(new Citizen(splitted[0], int.Parse(splitted[1]), splitted[2]));

                }
                else if (splitted.Length == 2)
                {
                    all.Add(new Robot(splitted[0], splitted[1]));
                }

                command = Console.ReadLine();
            }

            string invalidId = Console.ReadLine();

            all.Where(c => c.Id.EndsWith(invalidId))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
