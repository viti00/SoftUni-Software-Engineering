using System;

namespace _10.WordTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] temp = command.Split(":");
                string instruction = temp[0];
                switch (instruction)
                {
                    case "Add Stop":
                        int index = int.Parse(temp[1]);
                        string text = temp[2];
                        if (index >= 0 && index < input.Length)
                        {
                            input = input.Insert(index, text);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine(input);
                        }
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(temp[1]);
                        int endIndex = int.Parse(temp[2]);
                        if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine(input);
                        }
                        break;
                    case "Switch":
                        string oldString = temp[1];
                        string newString = temp[2];
                        if (input.Contains(oldString))
                        {
                            input = input.Replace(oldString, newString);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine(input);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
