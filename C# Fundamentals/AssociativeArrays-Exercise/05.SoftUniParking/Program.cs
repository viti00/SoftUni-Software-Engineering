using System;
using System.Collections.Generic;

namespace SoftuiniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> datas = new Dictionary<string, string>();
            for (int i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();
                string[] temp = data.Split();
                string command = temp[0];
                string name = temp[1];
                switch (command)
                {
                    case "register":
                        if (datas.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {temp[2]}");
                        }
                        else
                        {
                            datas.Add(name, temp[2]);
                            Console.WriteLine($"{name} registered {temp[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (datas.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} unregistered successfully");
                            datas.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                }
            }
            foreach (var item in datas)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
