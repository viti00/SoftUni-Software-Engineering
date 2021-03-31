using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            Action<string> printer = (x) => Console.WriteLine($"Sir {x}");
            strings.ToList().ForEach(x => printer(x));
        }
    }
}
