using System;
using System.Linq;
using System.Linq.Expressions;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> elements = new CustomStack<string>();
            string input = Console.ReadLine();
            string[] split = input.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            elements = new CustomStack<string>((split.Skip(1)));

            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] splitted = command.Split();

                switch (splitted[0])
                {
                    case "Push":
                        string element = splitted[1];
                        elements.Push(element);
                        break;
                    case "Pop":
                        elements.Pop();
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
