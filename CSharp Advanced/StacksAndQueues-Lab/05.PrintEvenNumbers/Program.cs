using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Enqueue(numbers[i]);
                }
            }

            while (evenNumbers.Count != 1)
            {
                Console.Write($"{evenNumbers.Dequeue()}" + ", ");
            }
            Console.Write(evenNumbers.Dequeue());
        }
    }
}
