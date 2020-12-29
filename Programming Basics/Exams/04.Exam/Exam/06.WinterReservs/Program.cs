using System;

namespace _06.WinterReservs
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyNeeded = double.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            double counter = 0.0;
            while (comand != "Winter has come")
            {
                for (int i = 1; i <= 6; i++)
                {
                    double extract = double.Parse(Console.ReadLine());
                    counter += extract;
                }
                if (counter > honeyNeeded)
                {
                    double remainder = counter - honeyNeeded;
                    Console.WriteLine($"Well done! Honey surplus {remainder:f2}.");
                    break;
                }
                else if (counter < 0)
                {
                    Console.WriteLine($"{comand} was banished for gluttony");
                }
                comand = Console.ReadLine();
            }
            if (counter < honeyNeeded)
            {
                double lick = double.Parse(Console.ReadLine());
                Console.WriteLine($"Hard Winter! Honey needed {lick:f2}.");
            }
        }
    }
}
