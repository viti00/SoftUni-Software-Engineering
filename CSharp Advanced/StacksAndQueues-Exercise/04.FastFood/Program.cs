using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] costumersQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>();

            for (int i = 0; i < costumersQuantity.Length; i++)
            {
                orders.Enqueue(costumersQuantity[i]);
            }

            Console.WriteLine(orders.Max());
            while (quantity > 0 && orders.Count != 0)
            {
                if (quantity - orders.Peek() >= 0)
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", orders));
            }
        }
    }
}
