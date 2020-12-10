using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int anotherAnimals = int.Parse(Console.ReadLine());
            double dogfoodPrice = dogsCount * 2.50;
            int anotherfoodPrice = anotherAnimals * 4;
            Console.WriteLine(dogfoodPrice + anotherfoodPrice + " lv.");
        }
    }
}
