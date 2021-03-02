using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace _15.Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> songs = new Dictionary<string, List<string>>();
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split("|");
                string piece = temp[0];
                string composer = temp[1];
                string key = temp[2];
                songs.Add(piece, new List<string> { composer, key });
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] token = command.Split("|");
                string instruction = token[0];
                string piece = token[1];
                switch (instruction)
                {
                    case "Add":

                        string composer = token[2];
                        string key = token[3];
                        if (songs.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            songs.Add(piece, new List<string> { composer, key });
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (songs.ContainsKey(piece))
                        {
                            songs.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        string newKey = token[2];
                        if (songs.ContainsKey(piece))
                        {
                            songs[piece][1] = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in songs.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
