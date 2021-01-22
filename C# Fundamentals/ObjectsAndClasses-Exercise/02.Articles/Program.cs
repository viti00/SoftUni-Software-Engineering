using System;
using System.Collections.Generic;
using System.Linq;

namespace Aritcles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articles = Console.ReadLine().Split(",").ToList();
            int n = int.Parse(Console.ReadLine());
            Aritcle article = new Aritcle();
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] temp = command.Split(":");

                switch (temp[0])
                {
                    case "Edit":
                        article.Content = temp[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = temp[1];
                        break;
                    case "Rename":
                        article.Title = temp[1];
                        break;
                }

            }
            Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");
        }
        public class Aritcle
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
        }
    }
}
