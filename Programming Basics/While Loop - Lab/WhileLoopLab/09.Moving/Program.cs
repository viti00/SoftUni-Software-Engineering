using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int duljina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double sum = 0.0;
            bool isSpaceEnough = true;
            double kubMetriStaq = shirochina * duljina * visochina;
            while (input != "Done")
            {
                sum = int.Parse(input);
                kubMetriStaq -= sum;
                if (kubMetriStaq <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(kubMetriStaq)} Cubic meters more.");
                    isSpaceEnough = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (isSpaceEnough)
            {
                Console.WriteLine($"{kubMetriStaq} Cubic meters left.");
            }
        }
    }
}
