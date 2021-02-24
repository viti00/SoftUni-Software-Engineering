using System;
using System.Linq;

namespace _7.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            string substring = "";
            while (command != "Reveal")
            {
                string[] temp = command.Split(":|:");
                string instruction = temp[0];
                switch (instruction)
                {
                    case "InsertSpace":
                        int index = int.Parse(temp[1]);
                        input = input.Insert(index, " ");
                        Console.WriteLine(input);
                        break;
                    case "Reverse":
                        substring = temp[1];
                        string reversed = "";
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversed += substring[i];
                        }
                        if (input.Contains(substring))
                        {
                            int firstIndex = input.IndexOf(substring);
                            input = input.Remove(firstIndex, substring.Length);
                            input = input.Insert(input.Length, reversed);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        substring = temp[1];
                        string replacement = temp[2];
                        input = input.Replace(substring, replacement);
                        Console.WriteLine(input);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
