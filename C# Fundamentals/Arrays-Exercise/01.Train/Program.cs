using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int peoples = int.Parse(Console.ReadLine());
                arr[i] = peoples;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int sum = arr.Sum();
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
