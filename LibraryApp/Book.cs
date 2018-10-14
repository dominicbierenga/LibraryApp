using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        public string[] Title { get; set; }
        public string[] Author { get; set; }
        public string[] Genre { get; set; }
        public int PubYear { get; set; }

        private Book(string[] title, string[] author, string[] genre, int pubYear)
        {
            Title = title;
            Author = author;
            Genre = genre;
            PubYear = pubYear;
        }

        public static Book BuildBook()
        {
            Console.WriteLine("Enter the book's title.");
            string[] title = Console.ReadLine().Trim().ToUpper().Split(' ');
            Console.WriteLine("Enter the book's author.");
            string[] author = Console.ReadLine().Trim().ToUpper().Split(' ');
            Console.WriteLine("Enter the book's genre.");
            string[] genre = Console.ReadLine().Trim().ToUpper().Split(' ');
            Console.WriteLine("Enter the book's year of publication.");
            try
            {
                int pubYear = Convert.ToInt32(Console.ReadLine());
                return new Book(title, author, genre, pubYear);
            }
            catch (FormatException)
            {
                Console.WriteLine("Publication year must be an integer.");
                return null;
            }               
        }
    }
}
