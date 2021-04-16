using System;

namespace _02.GenericBoxОfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int> listElements = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var element = int.Parse(Console.ReadLine());

                listElements.Add(element);
            }
            listElements.Foreach();
        }
    }
}
