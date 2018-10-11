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
  
            foreach (Book book in bookList.Where(x => x.Title.Contains(title.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(book.Title));
                Console.WriteLine("Author: " + JoinStringArray(book.Author));
                Console.WriteLine("Genre: " + JoinStringArray(book.Genre));
                Console.WriteLine("Published: " + book.PubYear + "\n");
            }
            
        }

        public void FindMovieByTitle(List<Movie> movieList, string title)
        {
            foreach (Movie movie in movieList.Where(x => x.Title.Contains(title.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(movie.Title));
                Console.WriteLine("Director: " + JoinStringArray(movie.Director));
                Console.WriteLine("Genre: " + JoinStringArray(movie.Genre));
                Console.WriteLine("Main Actor: " + JoinStringArray(movie.Actor) + "\n");
            }
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
