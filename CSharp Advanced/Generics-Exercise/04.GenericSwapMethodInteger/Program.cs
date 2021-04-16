using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
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

            int[] swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = swapCommand[0];
            int secondIndex = swapCommand[1];

            listElements.Swap(firstIndex, secondIndex);

            listElements.Foreach();
        }
    }
}
