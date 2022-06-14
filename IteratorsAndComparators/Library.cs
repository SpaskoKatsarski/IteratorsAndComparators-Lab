using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public List<Book> Books { get; private set; }

        public IEnumerator<Book> GetEnumerator()
        {
            //Books.Sort();
            for (int i = 0; i < Books.Count; i++)
            {
                yield return Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(Books);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = books;
        //        Reset();
        //    }

        //    private List<Book> books;
        //    private int position;

        //    public Book Current => books[position];

        //    object IEnumerator.Current => Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        position++;
        //        return position < books.Count;
        //    }

        //    public void Reset()
        //    {
        //        this.position = -1;
        //    }
        //}

    }
}
