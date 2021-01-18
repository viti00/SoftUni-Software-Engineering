using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }
                string[] token = comand.Split();
                switch (token[0])
                {
                    case "Delete":
                        int numToDelete = int.Parse(token[1]);
                        int currNum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            currNum = numbers[i];
                            if (currNum == numToDelete)
                            {
                                numbers.Remove(currNum);
                            }
                        }
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(token[1]);
                        int index = int.Parse(token[2]);
                        numbers.Insert(index, numToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
