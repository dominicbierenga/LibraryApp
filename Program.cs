using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library

{
    class BookModel
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublishingYear { get; set; }
    }
    class Books
    {
        List<BookModel> bList = new List<BookModel>();
        public void AddBook(BookModel bModel)
        {
            bList.Add(bModel);
        }
        public void SearchBookByAuthor(string BookAuthor)
        {
            List<BookModel> books = bList.Where(s => s.Author == BookAuthor).ToList();
            if (books == null)
            {
                Console.WriteLine("Sorry No book found with this author name");
            }
            else
            {
                Console.WriteLine("List of Books with Author");
                foreach (var item in books)
                {
                    Console.WriteLine("\n {0} \t {1} \t {2} \t {3}", item.BookName, item.Author, item.Genre, item.PublishingYear);
                }
            }
        }
        public void SearchBookByGenre(string BookGenre)
        {
            List<BookModel> books = bList.Where(s => s.Genre == BookGenre).ToList();
            if (books == null)
            {
                Console.WriteLine("Sorry No book found with this Genre");
            }
            else
            {
                Console.WriteLine("List of Books with Genre");
                foreach (var item in books)
                {
                    Console.WriteLine("\n {0} \t {1} \t {2} \t {3}", item.BookName, item.Author, item.Genre, item.PublishingYear);
                }
                
            }
        }
        public void GetListofBooks()
        {
            Console.WriteLine("List of Books");
            foreach(var item in bList)
            {
                Console.WriteLine("\n {0} \t {1} \t {2} \t {3}", item.BookName, item.Author, item.Genre, item.PublishingYear);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Books obj = new Books();
            do
            {
                Console.WriteLine("\n1. Add Book  2. List of Books     3. Find a Book By Author    4. Find a Book by Genre    5. Exit");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Book Name , Author , Genre , Publishing Year");
                        BookModel book = new BookModel();
                        book.BookName = Console.ReadLine();
                        book.Author = Console.ReadLine();
                        book.Genre = Console.ReadLine();
                        book.PublishingYear = Convert.ToInt32(Console.ReadLine());
                        obj.AddBook(book);
                        break;
                    case 2:
                        obj.GetListofBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter Author Name to Search");
                        string author = Console.ReadLine();
                        obj.SearchBookByAuthor(author);
                        break;
                    case 4:
                        Console.WriteLine("Enter Genre to Search");
                        string genre = Console.ReadLine();
                        obj.SearchBookByGenre(genre);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (true);
        }
    }
}
