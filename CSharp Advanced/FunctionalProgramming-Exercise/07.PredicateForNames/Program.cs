using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                                        .Split()
                                        .ToList();

            Func<List<string>, List<string>> getNames = names =>
            {
                List<string> correctNames = new List<string>();
                foreach (var name in names)
                {
                    if (name.Length <= n)
                    {
                        correctNames.Add(name);
                    }
                }
                return correctNames;
            };

            List<string> corretNames = getNames(names);

            Console.WriteLine(string.Join(Environment.NewLine, corretNames));
        }
    }
}
