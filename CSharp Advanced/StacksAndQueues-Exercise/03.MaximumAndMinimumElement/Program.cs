using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumАndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] temp = command.Split();
                int function = int.Parse(temp[0]);
                switch (function)
                {
                    case 1:
                        int num = int.Parse(temp[1]);
                        nums.Push(num);
                        break;
                    case 2:
                        nums.Pop();
                        break;
                    case 3:
                        if (nums.Count != 0)
                        {
                            Console.WriteLine(nums.Max());
                        }
                        break;
                    case 4:
                        if (nums.Count != 0)
                        {
                            Console.WriteLine(nums.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
