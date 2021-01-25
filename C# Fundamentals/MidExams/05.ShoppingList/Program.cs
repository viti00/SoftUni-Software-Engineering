using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();
            string item = string.Empty;
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "Go Shopping!")
                {
                    break;
                }
                string[] temp = comand.Split();
                switch (temp[0])
                {
                    case "Urgent":
                        item = temp[1];
                        if (products.Contains(item))
                        {
                            break;
                        }
                        else
                        {
                            products.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        item = temp[1];
                        if (products.Contains(item))
                        {
                            products.Remove(item);
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Correct":
                        item = temp[1];
                        string newItem = temp[2];
                        if (products.Contains(item))
                        {
                            for (int i = 0; i < products.Count; i++)
                            {
                                string currElement = products[i];
                                if (currElement == item)
                                {
                                    currElement = newItem;
                                    products[i] = currElement;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Rearrange":
                        item = temp[1];
                        if (products.Contains(item))
                        {
                            products.Remove(item);
                            products.Add(item);
                        }
                        else
                        {
                            break;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", products));
        }
    }
}
