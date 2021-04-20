using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListIterator<string> listElements = null;
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] splitted = command.Split();
                switch (splitted[0])
                {
                    case "Create":
                        listElements = new ListIterator<string>(splitted.Skip(1));
                        break;
                    case "Move":
                        Console.WriteLine(listElements.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listElements.HasNext());
                        break;
                    case "Print":
                        listElements.Print();
                        break;
                }
                command = Console.ReadLine();
            }
            
        }
    }
}
