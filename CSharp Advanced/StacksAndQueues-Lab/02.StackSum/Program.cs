using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersStack.Push(numbers[i]);
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] temp = command.Split();
                if (temp[0] == "add")
                {
                    int firstNum = int.Parse(temp[1]);
                    int secondNum = int.Parse(temp[2]);

                    numbersStack.Push(firstNum);
                    numbersStack.Push(secondNum);
                }
                else if (temp[0] == "remove")
                {
                    int count = int.Parse(temp[1]);
                    int counter = count;
                    if (count < numbersStack.Count)
                    {
                        while (counter != 0)
                        {
                            numbersStack.Pop();
                            counter--;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {numbersStack.Sum()}");
        }
    }
}
