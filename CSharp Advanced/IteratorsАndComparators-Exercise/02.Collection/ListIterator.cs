using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex;

        public ListIterator(IEnumerable<T> inputElements)
        {
            elements = new List<T>(inputElements);
        }

        public bool Move()
        {
            if (HasNext())
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (currentIndex + 1 >= elements.Count)
            {
                return false;
            }
            return true;
        }
        public void Print()
        {
            if (elements.Count > 0 && currentIndex >= 0 && currentIndex < elements.Count)
            {
                Console.WriteLine(elements[currentIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
        public string PrintAll()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < elements.Count; i++)
            {
                sb.Append($"{elements[i]} ");
            }
            return sb.ToString().Trim();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
