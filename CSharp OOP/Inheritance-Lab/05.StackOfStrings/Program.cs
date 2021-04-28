using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack1 = new StackOfStrings();

            Console.WriteLine(stack1.IsEmpty());

            stack1.AddRange(10);
            Console.WriteLine(string.Join(", ", stack1));

            Console.WriteLine(stack1.IsEmpty());
        }
    }
}
