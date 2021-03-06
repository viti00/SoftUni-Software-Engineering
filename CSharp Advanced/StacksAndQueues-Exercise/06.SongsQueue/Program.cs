using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(songs);
            while (songsQueue.Count != 0)
            {
                string command = Console.ReadLine();
                string[] temp = command.Split();
                string function = temp[0];
                switch (function)
                {
                    case "Add":
                        string song = "";
                        for (int i = 1; i < temp.Length - 1; i++)
                        {
                            song += $"{temp[i]} ";
                        }
                        song += temp[temp.Length - 1];
                        if (songsQueue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(song);
                        }
                        break;
                    case "Play":
                        songsQueue.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
