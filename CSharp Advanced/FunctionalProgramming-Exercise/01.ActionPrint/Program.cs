﻿using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split();
            Action<string> printStrings = (x) => Console.WriteLine(x);
            strings.ToList().ForEach(x => printStrings(x));

        }
    }
}
