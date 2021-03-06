using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    open.Push(item);
                }
                else
                {
                    if (open.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    if (item == '}' && open.Peek() == '{' || item == ']' && open.Peek() == '[' || item == ')' && open.Peek() == '(')
                    {
                        open.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                }
            }
            if (open.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
