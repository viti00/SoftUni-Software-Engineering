using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> all = new List<IBuyer>();
            

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    all.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                    
                }
                else if (input.Length == 3)
                {
                    all.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                   
                }
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                var buyer = all.FirstOrDefault(n => n.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(all.Sum(b=>b.Food));
        }
    }
}
