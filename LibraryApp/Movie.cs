using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Movie
    {
        public string Title { get; set; }
        public string Actor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public Movie()
        {
            Console.WriteLine("Enter the movie's title.");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the movie's actor.");
            Actor = Console.ReadLine();
            Console.WriteLine("Enter the movie's genre.");
            Genre = Console.ReadLine();
            Console.WriteLine("Enter the movie's director.");
            Director = Console.ReadLine();

            
        }
    }

}
