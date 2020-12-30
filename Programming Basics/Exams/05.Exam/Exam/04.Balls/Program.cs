using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pointCounter = 0;
            int redBallsCounter = 0;
            int orangeBallsCounter = 0;
            int yellowBallsCounter = 0;
            int whiteBallsCounter = 0;
            int blackBallsCounter = 0;
            int otherBallsCounter = 0;
            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    pointCounter += 5;
                    redBallsCounter++;
                }
                else if (color == "orange")
                {
                    pointCounter += 10;
                    orangeBallsCounter++;
                }
                else if (color == "yellow")
                {
                    pointCounter += 15;
                    yellowBallsCounter++;
                }
                else if (color == "white")
                {
                    pointCounter += 20;
                    whiteBallsCounter++;
                }
                else if (color == "black")
                {
                    pointCounter /= 2;
                    blackBallsCounter++;
                }
                else
                {
                    pointCounter += 0;
                    otherBallsCounter++;
                }
            }
            Console.WriteLine($"Total points: {pointCounter}");
            Console.WriteLine($"Points from red balls: {redBallsCounter}");
            Console.WriteLine($"Points from orange balls: {orangeBallsCounter}");
            Console.WriteLine($"Points from yellow balls: {yellowBallsCounter}");
            Console.WriteLine($"Points from white balls: {whiteBallsCounter}");
            Console.WriteLine($"Other colors picked: {otherBallsCounter}");
            Console.WriteLine($"Divides from black balls: {blackBallsCounter}");
        }
    }
}
