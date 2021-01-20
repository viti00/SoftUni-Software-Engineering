using System;
using System.Collections.Generic;

namespace _3.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 1; i <= n; i++)
            {
                string[] temp = Console.ReadLine().Split("_");
                string type = temp[0];
                string name = temp[1];
                string time = temp[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);

            }
            string listType = Console.ReadLine();
            if (listType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == listType)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }

    }
}
