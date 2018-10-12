using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Movie
    {
        public string[] Title { get; set; }
        public string[] Actor { get; set; }
        public string[] Genre { get; set; }
        public string[] Director { get; set; }

        private Movie(string[] title, string[] director, string[] genre, string[] actor)
        {
            Title = title;
            Director = director;
            Genre = genre;
            Actor = actor; 
        }

        public static Movie BuildMovie() 
        {
            Console.WriteLine("Enter the movie's title.");
            string[] title = Console.ReadLine().Trim().ToUpper().Split(' ');
            Console.WriteLine("Enter the movie's director.");
            string[] director = Console.ReadLine().Trim().ToUpper().Split(' ');
            Console.WriteLine("Enter the movie's genre.");
            string[] genre = Console.ReadLine().Trim().ToUpper().Split(' ');
            Console.WriteLine("Enter the movie's main actor.");
            string[] actor = Console.ReadLine().Trim().ToUpper().Split(' ');

            return new Movie(title, director, genre, actor);
        } 
    }
}
