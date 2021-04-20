using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        List<T> elements;

        public CustomStack(IEnumerable<T> items)
        {
            elements = new List<T>(items);
        }

        public CustomStack()
        {
            elements = new List<T>();
        }

        public void Push(T element)
        {
            elements.Add(element);
        }

        public void Pop()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                elements.Remove(elements[elements.Count - 1]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
