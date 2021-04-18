using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = new SortedSet<Book>(books, new BookComparator());
        }
        

        public SortedSet<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            public LibraryIterator(List<Book>books)
            {
                Books = books;
            }
            private int index = -1;
            public List<Book> Books { get; set; }

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
}
