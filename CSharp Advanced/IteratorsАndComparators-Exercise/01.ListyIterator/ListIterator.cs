using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace _01.ListyIterator
{
    public class ListIterator<T>
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
    }
}
