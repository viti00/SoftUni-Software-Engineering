using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        Stack<T> elements;

        public Box()
        {
            elements = new Stack<T>();
        }

        public void Add(T element)
        {
            elements.Push(element);
        }

        public T Remove()
        {
            T elementToRemove = elements.Pop();
            return elementToRemove;
        }

        public int Count { get { return elements.Count; } }
    }
}
