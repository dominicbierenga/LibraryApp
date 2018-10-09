using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PubYear { get; set; }

        public Book()
        {
            Console.WriteLine("Enter the book's title.");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the book's author.");
            Author = Console.ReadLine();
            Console.WriteLine("Enter the book's genre.");
            Genre = Console.ReadLine();
            Console.WriteLine("Enter the book's year of publication.");
            PubYear = Convert.ToInt32(Console.ReadLine());
        }
    }
}
