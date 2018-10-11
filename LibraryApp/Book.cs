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

<<<<<<< HEAD
        private int counter = 0;
        private string title;
        public string GetTitle() {
            counter++;
            return title;
        }
        public void SetTitle(string title) { this.title = title; }

        public void GetProperties()
=======
        private Book(string[] title, string[] author, string[] genre, int pubYear)
        {
            Title = title;
            Author = author;
            Genre = genre;
            PubYear = pubYear;
        }

        public static Book BuildBook()
>>>>>>> e67288278e572b41b3318fb49f23a873032ef3be
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
            catch (FormatException e)
            {
                Console.WriteLine("Publication year must be an integer.");
                return null;
            }               
        }
    }
}
