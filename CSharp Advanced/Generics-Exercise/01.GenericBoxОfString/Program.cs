using System;

namespace _01.GenericBoxОfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> listElements = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var element = Console.ReadLine();

                listElements.Add(element);
            }
            listElements.Foreach();

        }
    }
}
