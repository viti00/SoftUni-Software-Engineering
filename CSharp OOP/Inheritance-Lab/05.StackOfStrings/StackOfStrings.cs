using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            return false;
        }

        public Stack<string> AddRange(int range)
        {
            for (int i = 0; i < range; i++)
            {
                this.Push($"{i}");
            }

            return this;
        }
    }
}
