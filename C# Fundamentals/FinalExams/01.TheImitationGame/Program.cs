using System;
using System.Linq;

namespace _13.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            string result = "";
            while (command != "Decode")
            {
                string[] temp = command.Split("|");
                string instructions = temp[0];
                switch (instructions)
                {
                    case "Move":
                        int num = int.Parse(temp[1]);
                        for (int i = 0; i < num; i++)
                        {
                            char ch = input[i];
                            result += ch;
                        }
                        input = input.Remove(0, num);
                        input = input.Insert(input.Length, result);
                        result = "";
                        break;
                    case "Insert":
                        int index = int.Parse(temp[1]);
                        string value = temp[2];
                        input = input.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = temp[1];
                        string replacement = temp[2];
                        input = input.Replace(substring, replacement);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
