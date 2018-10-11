using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryApp
{
    public class User
    {
        public void FindByTitle(List<Book> bookList, string title)
        {
            Console.WriteLine("\nYour search returned the following books.");
<<<<<<< HEAD

            for (int i=0; i<bookList.Count; i++)
            {
                Book book = bookList[i];
                if (book.Title == title.ToUpper())
                {
                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Genre: " + book.Genre);
                    Console.WriteLine("Published: " + book.PubYear);
                    break;
                }
            }



            /*
            foreach (Book book in bookList.Where(x => x.Title == title.ToUpper()))
=======
            foreach (Book book in bookList.Where(x => x.Title.Contains(title.ToUpper())))
>>>>>>> e67288278e572b41b3318fb49f23a873032ef3be
            {
                Console.WriteLine("Title: " + JoinStringArray(book.Title));
                Console.WriteLine("Author: " + JoinStringArray(book.Author));
                Console.WriteLine("Genre: " + JoinStringArray(book.Genre));
                Console.WriteLine("Published: " + book.PubYear + "\n");
            }
            */
        }

        public void FindByAuthor(List<Book> bookList, string author)
        {
            Console.WriteLine("\nYour search returned the following books.");
            foreach (Book book in bookList.Where(x => x.Author.Contains(author.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(book.Title));
                Console.WriteLine("Author: " + JoinStringArray(book.Author));
                Console.WriteLine("Genre: " + JoinStringArray(book.Genre));
                Console.WriteLine("Published: " + book.PubYear + "\n");
            }
        }

        public void FindByGenre(List<Book> bookList, string genre)
        {
            Console.WriteLine("\nYour search returned the following books.");
            foreach (Book book in bookList.Where(x => x.Genre.Contains(genre.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(book.Title));
                Console.WriteLine("Author: " + JoinStringArray(book.Author));
                Console.WriteLine("Genre: " + JoinStringArray(book.Genre));
                Console.WriteLine("Published: " + book.PubYear + "\n");
            }
        }

        public void AddBook(List<Book> bookList)
        {
            Book newBook = Book.BuildBook();
            bookList.Add(newBook);
        }

        private string JoinStringArray(string[] a)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string word in a)
            {
                builder.Append(word);
                builder.Append(" ");
            }
            return builder.ToString().Trim();
        }
    }
}
