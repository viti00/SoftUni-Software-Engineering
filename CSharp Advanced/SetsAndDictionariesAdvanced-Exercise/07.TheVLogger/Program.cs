using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, HashSet<string>>> vlogers = new Dictionary<string, Dictionary<string, HashSet<string>>>();


            while (command != "Statistics")
            {
                string[] temp = command.Split();
                string funtion = temp[1];
                switch (funtion)
                {
                    case "joined":
                        string vlogName = temp[0];
                        if (!vlogers.ContainsKey(vlogName))
                        {
                            vlogers.Add(vlogName, new Dictionary<string, HashSet<string>>());
                            vlogers[vlogName].Add("followers", new HashSet<string>());
                            vlogers[vlogName].Add("following", new HashSet<string>());
                        }

                        break;
                    case "followed":
                        string follower = temp[0];
                        string followed = temp[2];

                        if (follower != followed && vlogers.ContainsKey(follower) && vlogers.ContainsKey(followed))
                        {
                            vlogers[followed]["followers"].Add(follower);
                            vlogers[follower]["following"].Add(followed);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vlogger in vlogers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers" +
                    $", {vlogger.Value["following"].Count} following");
                if (count == 1)
                {
                    foreach (var value in vlogger.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {value}");
                    }
                }
                count++;
            }
        }
    }
}
