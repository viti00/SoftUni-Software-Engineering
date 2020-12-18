using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int total = width * hight;
            int pieceCounter = 0;
            while (total >= pieceCounter)
            {
                string pieces = Console.ReadLine();
                if (pieces == "STOP")
                {
                    Console.WriteLine($"{total - pieceCounter} pieces are left.");
                    break;
                }
                pieceCounter += int.Parse(pieces);
            }
            if (pieceCounter > total)
            {
                Console.WriteLine($"No more cake left! You need {pieceCounter - total} pieces more.");
            }
        }
    }
}
