using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int elementFisrtHand = 0;
            int elementSecondHand = 0;
            while (firstHand.Count != 0 && secondHand.Count != 0)
            {
                for (int i = 0; i < firstHand.Count;)
                {
                    elementFisrtHand = firstHand[i];
                    if (firstHand.Count == 0 || secondHand.Count == 0)
                    {
                        break;
                    }
                    for (int j = 0; j < secondHand.Count;)
                    {
                        elementSecondHand = secondHand[j];
                        if (elementFisrtHand > elementSecondHand)
                        {
                            firstHand.Add(elementFisrtHand);
                            firstHand.Add(elementSecondHand);
                            firstHand.Remove(firstHand[i]);
                            secondHand.Remove(secondHand[j]);
                        }
                        else if (elementSecondHand > elementFisrtHand)
                        {
                            secondHand.Add(elementSecondHand);
                            secondHand.Add(elementFisrtHand);
                            secondHand.Remove(secondHand[j]);
                            firstHand.Remove(firstHand[i]);
                        }
                        else
                        {
                            firstHand.Remove(firstHand[i]);
                            secondHand.Remove(secondHand[j]);
                        }
                        break;
                    }
                }
            }
            int sum = 0;
            if (firstHand.Count > secondHand.Count)
            {
                sum = firstHand.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondHand.Count > firstHand.Count)
            {
                sum = secondHand.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
