using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNum = elements[0];
            int power = Math.Abs(elements[1]);

            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                   
                    int start = i - power;

                    
                    if (start < 0)
                    {
                        start = 0;
                    }

                    
                    int finish = i + power + 1;

                    
                    if (finish > numbers.Count)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        numbers.RemoveAt(start);
                    }
                    i--;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
