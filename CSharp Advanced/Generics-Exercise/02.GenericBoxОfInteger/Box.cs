using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxОfInteger
{
    public class Box<T>
    {
        List<T> elements;

        public Box()
        {
            elements = new List<T>();
        }

        public void Add(T item)
        {
            elements.Add(item);
        }

        public void Foreach()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine($"{elements[i].GetType()}: {elements[i]}");
            }
        }
    }
}
