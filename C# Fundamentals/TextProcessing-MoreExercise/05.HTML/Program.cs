using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            string comment = Console.ReadLine();
            List<string> comments = new List<string>();
            while (comment != "end of comments")
            {
                comments.Add(comment);
                comment = Console.ReadLine();
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</article>");
            foreach (var item in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {item}");
                Console.WriteLine("</div>");
            }
        }
    }
}
