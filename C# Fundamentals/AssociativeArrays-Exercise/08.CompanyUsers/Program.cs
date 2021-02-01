using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> datas = new Dictionary<string, List<string>>();
            while (command != "End")
            {
                string[] temp = command.Split(" -> ");
                string companyName = temp[0];
                string employeeId = temp[1];
                if (datas.ContainsKey(companyName))
                {
                    if (datas[companyName].Contains(employeeId))
                    {

                    }
                    else
                    {
                        datas[companyName].Add(employeeId);
                    }
                }
                else
                {
                    datas.Add(companyName, new List<string> { employeeId });
                }
                command = Console.ReadLine();
            }
            foreach (var curr in datas.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{curr.Key}");
                foreach (var item in curr.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}

