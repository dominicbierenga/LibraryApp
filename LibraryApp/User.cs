using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    public class User
    {
        public void FindByTitle(List<Book> bookList, string title)
        {
            Console.WriteLine("\nYour search returned the following books.");
            foreach (Book book in bookList.Where(x => x.Title == title.ToUpper()))
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Published: " + book.PubYear);
            }
        }

        public void FindByAuthor(List<Book> bookList, string author)
        {
            Console.WriteLine("\nYour search returned the following books.");
            foreach (Book book in bookList.Where(x => x.Author == author.ToUpper()))
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Published: " + book.PubYear);
            }
        }

        public void FindByGenre(List<Book> bookList, string genre)
        {
            Console.WriteLine("\nYour search returned the following books.");
            foreach (Book book in bookList.Where(x => x.Genre == genre.ToUpper()))
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Published: " + book.PubYear);
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
            Console.WriteLine("\nAre you sure you would like to quit? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Environment.Exit(-1);
            }
        }
    }
}
