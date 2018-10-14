using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryApp
{
    public class User
    {
        public virtual void FindBookByTitle(List<Book> bookList, string title)
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

        public void FindBookByGenre(List<Book> bookList, string genre)
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

        public void FindMovieByTitle(List<Movie> movieList, string title)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Title.Contains(title.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(movie.Title));
                Console.WriteLine("Director: " + JoinStringArray(movie.Director));
                Console.WriteLine("Genre: " + JoinStringArray(movie.Genre));
                Console.WriteLine("Main Actor: " + JoinStringArray(movie.Actor) + "\n");
            }
        }

        public void FindMovieByDirector(List<Movie> movieList, string director)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Director.Contains(director.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(movie.Title));
                Console.WriteLine("Director: " + JoinStringArray(movie.Director));
                Console.WriteLine("Genre: " + JoinStringArray(movie.Genre));
                Console.WriteLine("Main Actor: " + JoinStringArray(movie.Actor) + "\n");
            }
        }

        public void FindMovieByGenre(List<Movie> movieList, string genre)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Genre.Contains(genre.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(movie.Title));
                Console.WriteLine("Director: " + JoinStringArray(movie.Director));
                Console.WriteLine("Genre: " + JoinStringArray(movie.Genre));
                Console.WriteLine("Main Actor: " + JoinStringArray(movie.Actor) + "\n");
            }
        }

        public void FindMovieByActor(List<Movie> movieList, string actor)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Actor.Contains(actor.ToUpper())))
            {
                Console.WriteLine("Title: " + JoinStringArray(movie.Title));
                Console.WriteLine("Director: " + JoinStringArray(movie.Director));
                Console.WriteLine("Genre: " + JoinStringArray(movie.Genre));
                Console.WriteLine("Main Actor: " + JoinStringArray(movie.Actor) + "\n");
            }
        }

        public void AddMovie(List<Movie> movieList)
        {
            Movie newMovie = Movie.BuildMovie();
            movieList.Add(newMovie);
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
