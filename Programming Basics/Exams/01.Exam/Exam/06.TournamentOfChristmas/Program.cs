using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int winCounter = 0;
            int loseCounter = 0;
            double winMoney = 0.0;
            double totalMoney = 0.0;
            double finalMoney = 0.0;
            int totalWinCounter = 0;
            int totalLoseCounter = 0;
            for (int i = 1; i <= days; i++)
            {
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    string result = Console.ReadLine();
                    if (input == "Finish")
                    {
                        continue;
                    }
                    if (result == "win")
                    {
                        winMoney += 20;
                        winCounter++;
                        totalWinCounter += winCounter;
                    }
                    else if (result == "lose")
                    {
                        loseCounter++;
                        totalLoseCounter += loseCounter;
                    }
                    input = Console.ReadLine();
                }
                if (winCounter > loseCounter)
                {
                    totalMoney += winMoney + (winMoney * 0.1);
                }
                else
                {
                    totalMoney += winMoney;
                }
                winMoney = 0;
                winCounter = 0;
                loseCounter = 0;
            }
            if (totalWinCounter > totalLoseCounter)
            {
                finalMoney = totalMoney + (totalMoney * 0.2);
                Console.WriteLine($"You won the tournament! Total raised money: {finalMoney:f2}");
            }
            else
            {
                finalMoney = totalMoney;
                Console.WriteLine($"You lost the tournament! Total raised money: {finalMoney:F2}");
            }
        }
    }
}
