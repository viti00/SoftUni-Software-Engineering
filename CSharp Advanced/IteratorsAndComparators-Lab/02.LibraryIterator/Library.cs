using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerator<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public List<Book> Books { get; set; }

        private int index = -1;

        public Book Current => Books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            index++;
            if (Books.Count <= index)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
