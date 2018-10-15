using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            List<Movie> movieList = new List<Movie>();
            User user = new User();

            TopMenu(user, bookList, movieList);
        }

        static void TopMenu(User user, List<Book> bookList, List<Movie> movieList)
        {
            int choice = -1;

            while (choice != 3)
            {
                Console.WriteLine("\nWould you like to \n" +
                    "1. Enter the library app\n" +
                    "2. Enter the movie app\n" +
                    "3. Exit\n" +
                    "Enter a number for a response: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        int action = -1;

                        LibraryMenu(action, bookList, user);
                    }

                    else if (choice == 2)
                    {
                        int action = -1;

                        MovieMenu(action, movieList, user);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be an integer.");
                }
            }
        }

        static void LibraryMenu(int action, List<Book> bookList, User user)
        {
            while (action != 7)
            {
                Console.WriteLine("\nWould you like to \n" +
                    "1. Add a book\n" +
                    "2. Delete a book\n" +
                    "3. Search by title\n" +
                    "4. Search by author\n" +
                    "5. Search by genre\n" +
                    "6. Display the list of books\n" +
                    "7. Switch functionalities\n" +
                    "Enter a number for a response: ");

                try
                {
                    action = Convert.ToInt32(Console.ReadLine());

                    if (action == 1)
                    {
                        user.AddBook(bookList);
                    }
                    else if (action == 2)
                    {
                        Console.WriteLine("Enter the title of the book you would like to delete: ");
                        string title = Console.ReadLine();
                        user.DeleteBook(bookList, title);
                    }
                    else if (action == 3)
                    {
                        Console.WriteLine("Enter the title you would like to search for: ");
                        string title = Console.ReadLine();
                        user.FindBookByTitle(bookList, title);
                    }
                    else if (action == 4)
                    {
                        Console.WriteLine("Enter the author you would like to search for: ");
                        string author = Console.ReadLine();
                        user.SearchBookByAuthor(bookList, author);
                    }
                    else if (action == 5)
                    {
                        Console.WriteLine("Enter the genre you would like to search for: ");
                        string genre = Console.ReadLine();
                        user.SearchBookByGenre(bookList, genre);
                    }
                    else if (action == 6)
                    {
                        user.GetListofBooks(bookList);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be an integer.");
                }
            }
        }

        static void MovieMenu(int action, List<Movie> movieList, User user)
        {
            while (action != 8)
            {
                Console.WriteLine("\nWould you like to \n" +
                    "1. Add a movie\n" +
                    "2. Delete a movie\n" +
                    "3. Search by title\n" +
                    "4. Search by director\n" +
                    "5. Search by genre\n" +
                    "6. Search by lead actor/actress\n" +
                    "7. Display the list of movies\n" +
                    "8. Switch functionalities\n" +
                    "Enter a number for a response: ");

                try
                {
                    action = Convert.ToInt32(Console.ReadLine());

                    if (action == 1)
                    {
                        user.AddMovie(movieList);
                    }
                    else if (action == 2)
                    {
                        Console.WriteLine("Enter the title of the movie you would like to delete: ");
                        string title = Console.ReadLine();
                        user.DeleteMovie(movieList, title);
                    }
                    else if (action == 3)
                    {
                        Console.WriteLine("Enter the title you would like to search for: ");
                        string title = Console.ReadLine();
                        user.FindMovieByTitle(movieList, title);
                    }
                    else if (action == 4)
                    {
                        Console.WriteLine("Enter the director you would like to search for: ");
                        string director = Console.ReadLine();
                        user.FindMovieByDirector(movieList, director);
                    }
                    else if (action == 5)
                    {
                        Console.WriteLine("Enter the genre you would like to search for: ");
                        string genre = Console.ReadLine();
                        user.FindMovieByGenre(movieList, genre);
                    }
                    else if (action == 6)
                    {
                        Console.WriteLine("Enter the actor/actress you would like to search for: ");
                        string actor = Console.ReadLine();
                        user.FindMovieByActor(movieList, actor);
                    }
                    else if (action == 7)
                    {
                        user.GetListofMovies(movieList);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be an integer.");
                }
            }
        }
    }
}
