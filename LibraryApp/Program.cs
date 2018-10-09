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

            //testing
            User user = new User();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            book1.AddBookByDefault("Alice's Adventures in Wonderland", "Lewis Carroll", "Fantasy", 1865);
            book2.AddBookByDefault("The Catcher in the Rye", "J.D. Salinger", "Bildungsroman", 1951);
            book3.AddBookByDefault("Through the Looking Glass", "Lewis Carroll", "Fantasy", 1871);

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);

            List<Book> newList = user.FindByAuthor(bookList, "Lewis Carroll");
            foreach (Book book in newList)
            {
                Console.WriteLine(book.Title);
            }

            bookList.Where(x => x.Author == "Lewis Carroll");
        }

        static void UserMenu()
        {
            Console.WriteLine("Would you like to \n" +
                "1. Add a book\n" +
                "2. Search by title\n" +
                "3. Search by author\n" +
                "4. Search by genre\n" +
                "5. Search by publication year" +
                "6. Exit");
        }
    }
}
