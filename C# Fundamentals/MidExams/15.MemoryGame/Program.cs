using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            int index1 = 0;
            int index2 = 0;
            int moveCounter = 0;
            while (command != "end")
            {
                string[] temp = command.Split();
                index1 = int.Parse(temp[0]);
                index2 = int.Parse(temp[1]);
                moveCounter++;
                if (index1 != index2 && index1 >= 0 && index1 < numbers.Count && index2 >= 0 && index2 < numbers.Count)
                {
                    if (numbers[index1] == numbers[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");
                        if (index1 > index2)
                        {
                            numbers.RemoveAt(index1);
                            numbers.RemoveAt(index2);
                        }
                        else if (index2 > index1)
                        {
                            numbers.RemoveAt(index2);
                            numbers.RemoveAt(index1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    string item = $"-{moveCounter}a";
                    numbers.Insert(numbers.Count / 2, item);
                    numbers.Insert(numbers.Count / 2, item);
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCounter} turns!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
