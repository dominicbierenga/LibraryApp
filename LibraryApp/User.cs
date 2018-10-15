using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryApp
{
    public class User
    {
        #region Book Methods

        public virtual void FindBookByTitle(List<Book> bookList, string title)
        {
            Console.WriteLine("\nYour search returned the following books.");
            foreach (Book book in bookList.Where(x => x.Title.Contains(title.ToUpper())))
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Published: " + book.PubYear + "\n");
            }
        }

        public void SearchBookByAuthor(List<Book> bList, string BookAuthor)
        {
            List<Book> books = bList.Where(s => s.Author == BookAuthor.ToUpper()).ToList();
            if (books.Count() == 0)
            {
                Console.WriteLine("Sorry No book found with this author name.");
            }
            else
            {
                Console.WriteLine("List of Books with Author");
                foreach (var item in books)
                {
                    Console.WriteLine("\n{0} \t {1} \t {2} \t {3}", item.Title, item.Author, item.Genre, item.PubYear);
                }
            }
        }

        public void SearchBookByGenre(List<Book> bList, string BookGenre)
        {
            List<Book> books = bList.Where(s => s.Genre == BookGenre.ToUpper()).ToList();
            if (books.Count() == 0)
            {
                Console.WriteLine("Sorry No book found with this Genre");
            }
            else
            {
                Console.WriteLine("List of Books with Genre");
                foreach (var item in books)
                {
                    Console.WriteLine("\n{0} \t {1} \t {2} \t {3}", item.Title, item.Author, item.Genre, item.PubYear);
                }

            }
        }

        public void GetListofBooks(List<Book> bList)
        {
            Console.WriteLine("List of Books");
            foreach (var item in bList)
            {
                Console.WriteLine("\n{0} \t {1} \t {2} \t {3}", item.Title, item.Author, item.Genre, item.PubYear);
            }
        }

        public void AddBook(List<Book> bookList)
        {
            Book newBook = Book.BuildBook();
            bookList.Add(newBook);
        }

        public void DeleteBook(List<Book> bookList, string title)
        {
            foreach (Book book in bookList)
            {
                if (title.ToUpper() == book.Title)
                {
                    bookList.Remove(book);
                    break;
                }
            }
        }

        #endregion
        #region Movie Methods

        public void FindMovieByTitle(List<Movie> movieList, string title)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Title.Contains(title.ToUpper())))
            {
                Console.WriteLine("Title: " + movie.Title);
                Console.WriteLine("Director: " + movie.Director);
                Console.WriteLine("Genre: " + movie.Genre);
                Console.WriteLine("Main Actor: " + movie.Actor + "\n");
            }
        }

        public void FindMovieByDirector(List<Movie> movieList, string director)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Director.Contains(director.ToUpper())))
            {
                Console.WriteLine("Title: " + movie.Title);
                Console.WriteLine("Director: " + movie.Director);
                Console.WriteLine("Genre: " + movie.Genre);
                Console.WriteLine("Main Actor: " + movie.Actor + "\n");
            }
        }

        public void FindMovieByGenre(List<Movie> movieList, string genre)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Genre.Contains(genre.ToUpper())))
            {
                Console.WriteLine("Title: " + movie.Title);
                Console.WriteLine("Director: " + movie.Director);
                Console.WriteLine("Genre: " + movie.Genre);
                Console.WriteLine("Main Actor: " + movie.Actor + "\n");
            }
        }

        public void FindMovieByActor(List<Movie> movieList, string actor)
        {
            Console.WriteLine("\nYour search returned the following movies.");
            foreach (Movie movie in movieList.Where(x => x.Actor.Contains(actor.ToUpper())))
            {
                Console.WriteLine("Title: " + movie.Title);
                Console.WriteLine("Director: " + movie.Director);
                Console.WriteLine("Genre: " + movie.Genre);
                Console.WriteLine("Main Actor: " + movie.Actor + "\n");
            }
        }

        public void GetListofMovies(List<Movie> movieList)
        {
            Console.WriteLine("List of Movies");
            foreach (var item in movieList)
            {
                Console.WriteLine("\n{0} \t {1} \t {2} \t {3}", item.Title, item.Director, item.Genre, item.Actor);
            }
        }

        public void AddMovie(List<Movie> movieList)
        {
            Movie newMovie = Movie.BuildMovie();
            movieList.Add(newMovie);
        }

        public void DeleteMovie(List<Movie> movieList, string title)
        {
            foreach (Movie movie in movieList)
            {
                if (title.ToUpper() == movie.Title)
                {
                    movieList.Remove(movie);
                    break;
                }
            }
        }

        #endregion
    }
}
