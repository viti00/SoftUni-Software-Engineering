using System;

namespace CountreStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonCounter = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCounter} won battles and {energy} energy");
                    return;
                }
                wonCounter++;
                energy -= distance;
                if (wonCounter % 3 == 0)
                {
                    energy += wonCounter;
                }
            }
            Console.WriteLine($"Won battles: {wonCounter}. Energy left: {energy}");
        }
    }
}
