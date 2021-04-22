using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[] threads = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int value = int.Parse(Console.ReadLine());

            Stack<int> tasksStack = new Stack<int>(tasks);
            Queue<int> queueThreads = new Queue<int>(threads);
            while (true)
            {

                if (tasksStack.Peek() == value)
                {
                    Console.WriteLine($"Thread with value {queueThreads.Peek()} killed task {tasksStack.Peek()}");
                    Console.WriteLine(string.Join(" ", queueThreads));
                    return;
                }
                if (queueThreads.Peek() >= tasksStack.Peek() && tasksStack.Peek() != value)
                {
                    queueThreads.Dequeue();
                    tasksStack.Pop();
                }
                else
                {
                    queueThreads.Dequeue();
                }
            }
        }
    }
}
