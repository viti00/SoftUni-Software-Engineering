using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colections = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();
            string item = string.Empty;
            while (command != "Craft!")
            {
                string[] temp = command.Split(" - ");
                switch (temp[0])
                {
                    case "Collect":
                        item = temp[1];
                        if (colections.Contains(item))
                        {
                            break;
                        }
                        else
                        {
                            colections.Add(item);
                        }
                        break;
                    case "Drop":
                        item = temp[1];
                        if (colections.Contains(item))
                        {
                            colections.Remove(item);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Combine Items":
                        string[] splited = temp[1].Split(":");
                        item = splited[0];
                        string newItem = splited[1];
                        if (colections.Contains(item))
                        {
                            for (int i = 0; i < colections.Count; i++)
                            {
                                if (colections[i] == item)
                                {
                                    colections.Insert(i + 1, newItem);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Renew":
                        item = temp[1];
                        if (colections.Contains(item))
                        {
                            colections.Remove(item);
                            colections.Add(item);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", colections));
        }
    }
}
