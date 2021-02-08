using System;
using System.Linq;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string reverse = "";
            while (command != "end")
            {
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reverse += command[i];
                }
                Console.WriteLine($"{command} = {reverse}");
                reverse = "";
                command = Console.ReadLine();
            }
        }
    }
}
