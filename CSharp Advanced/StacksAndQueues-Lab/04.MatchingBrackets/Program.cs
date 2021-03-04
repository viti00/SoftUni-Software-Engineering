using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].ToString() == "(")
                {
                    brackets.Push(i);
                }
                else if (expression[i].ToString() == ")")
                {
                    brackets.Push(i);
                    int endIndex = brackets.Pop();
                    int startIndex = brackets.Pop();
                    string result = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
