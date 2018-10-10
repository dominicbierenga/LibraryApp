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
            User user = new User();

            UserMenu(user, bookList);
        }

        static void UserMenu(User user, List<Book> bookList)
        {
            int action = -1;

            while (action != 5)
            {
                Console.WriteLine("\nWould you like to \n" +
                "1. Add a book\n" +
                "2. Search by title\n" +
                "3. Search by author\n" +
                "4. Search by genre\n" +
                "5. Exit\n" +
                "Enter a number for a response: ");

                action = Convert.ToInt32(Console.ReadLine());

                if (action == 1)
                {
                    user.AddBook(bookList);
                }
                else if (action == 2)
                {
                    Console.WriteLine("Enter the title you would like to search for: ");
                    string title = Console.ReadLine();
                    user.FindByTitle(bookList, title);
                }
                else if (action == 3)
                {
                    Console.WriteLine("Enter the author you would like to search for: ");
                    string author = Console.ReadLine();
                    user.FindByAuthor(bookList, author);
                }
                else if (action == 4)
                {
                    Console.WriteLine("Enter the genre you would like to search for: ");
                    string genre = Console.ReadLine();
                    user.FindByGenre(bookList, genre);
                }
            }
        }
    }
}
