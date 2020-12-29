using System;

namespace _02.BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int iq = int.Parse(Console.ReadLine());
            int strong = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (iq >= 80 && strong >= 80 && sex == "female")
            {
                Console.WriteLine("Queen Bee");

            }
            else if (iq >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (iq >= 60 && iq < 80)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (strong >= 80 && sex == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (strong >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
