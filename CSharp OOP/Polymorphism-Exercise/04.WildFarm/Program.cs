using _04.WildFarm.Fctories;
using _04.WildFarm.Models;
using System;
using System.Collections.Generic;

namespace _04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitted = command.Split();

                Animal animal = AnimalFactory.Create(splitted);
                animals.Add(animal);

                Food food = FoodFactory.Create(Console.ReadLine().Split());

                try
                {
                    Console.WriteLine(animal.ProducingSound());
                    animal.EatFod(food);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

                command = Console.ReadLine();
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
