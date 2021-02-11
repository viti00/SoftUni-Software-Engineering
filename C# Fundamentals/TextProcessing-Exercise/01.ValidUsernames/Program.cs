using System;
using System.Collections.Generic;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            string result = "";
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {
                    foreach (var ch in usernames[i])
                    {
                        if (Char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
                        {
                            result += ch;
                            if (result.Length == usernames[i].Length)
                            {
                                Console.WriteLine(result);
                            }
                        }
                    }
                    result = "";
                }
            }
        }
    }
}
