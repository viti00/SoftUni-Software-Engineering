using System;
using System.Linq;

namespace _03.GenericSwapMethodString
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

            int[] swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = swapCommand[0];
            int secondIndex = swapCommand[1];

            listElements.Swap(firstIndex, secondIndex);

            listElements.Foreach();
        }
    }
}
