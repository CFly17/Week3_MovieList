using System;

namespace Week3_MovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDatabase MovieList = new MovieDatabase();

            Console.WriteLine("Welcome to the Grand Movie List!");
            Console.WriteLine("Here is a list of all the movies: ");
            Console.WriteLine();

            MovieList.PrintMovies();

            Console.WriteLine();

            MovieList.SearchGenre();

        }
    }
}
