using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case (new)", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("Something", 1930);
            Book newBook = new Book("BOOK", 1931);
            Book newBook2 = new Book("BOOK", 2000);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookThree, bookTwo, newBook, newBook2);

            //Console.WriteLine(libraryTwo.First(b => b.Title.StartsWith('T')).Title);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
            Console.WriteLine("SORTED BY EXTERNAL COMPARER:");
            Console.WriteLine();
            var books = libraryTwo.ToArray();
            Array.Sort(books, new BookComparator());

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
