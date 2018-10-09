using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    public class User
    {
        public List<Book> FindByTitle(List<Book> bookList, string title)
        {
            List<Book> byTitle = new List<Book>();
            foreach (Book book in bookList)
            {
                if (title == book.Title)
                {
                    byTitle.Add(book);
                }
            }

            if (!(byTitle.Count() == 0))
            {
                return byTitle;
            }
            else
            {
                Console.WriteLine("No book with that title is in the list.");
                return null;
            }
        }

        public List<Book> FindByAuthor(List<Book> bookList, string author)
        {
            List<Book> byAuthor = new List<Book>();
            foreach (Book book in bookList)
            {
                if (book.Author == author)
                {
                    byAuthor.Add(book);
                }
            }

            if (!(byAuthor.Count() == 0))
            {
                return byAuthor;
            }
            else
            {
                Console.WriteLine("There are no books by that author in the list.");
                return null;
            }
        }

        public List<Book> FindByGenre(List<Book> bookList, string genre)
        {
            List<Book> byGenre = new List<Book>();
            foreach (Book book in bookList)
            {
                if (book.Genre == genre)
                {
                    byGenre.Add(book);
                }
            }

            if (!(byGenre.Count() == 0))
            {
                return byGenre;
            }
            else
            {
                Console.WriteLine("There are no books of that genre in the list.");
                return null;
            }
        }

        public void AddBook(List<Book> bookList)
        {
            Book newBook = new Book();
            newBook.GetProperties();
            bookList.Add(newBook);
        }

        public void Quit()
        {
            Console.WriteLine("Are you sure you would like to quit? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Environment.Exit(-1);
            }
        }
    }
}
