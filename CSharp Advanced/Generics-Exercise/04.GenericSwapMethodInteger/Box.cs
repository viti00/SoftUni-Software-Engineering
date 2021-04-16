using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        List<T> elements;

        public Box()
        {
            elements = new List<T>();
        }

        public void Add(T element)
        {
            elements.Add(element);
        }

        public void Swap (int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < elements.Count &&
                secondIndex >= 0 && secondIndex < elements.Count)
            {
                T firstElement = elements[firstIndex];
                T secondElement = elements[secondIndex];

                elements[firstIndex] = secondElement;
                elements[secondIndex] = firstElement;
            }
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
