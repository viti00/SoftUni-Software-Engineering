﻿using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
                if (text == "Stop")
                {
                    break;
                }
            }
        }
    }
}
