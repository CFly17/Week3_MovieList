using System;
using System.Collections.Generic;
using System.Linq;

namespace Week3_MovieListLab
{
    class MovieDatabase
    {
        //to include the following methods:
        //Get Input
        //Continue?
        //Print Movies
        //this could be edited to print by genre
        //What Genre would you like to know more about?
        //three options
        //Validation

        //Declare movie list:
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //Initialize movie list:
        public MovieDatabase()
        {
            Movies.Add(new Movie("Terrifier", 2016, "Horror"));
            Movies.Add(new Movie("Hellraiser", 1987, "Horror"));
            Movies.Add(new Movie("The Cabinet of Dr. Caligari", 1920, "Horror"));
            Movies.Add(new Movie("Finding Nemo", 2003, "Animated"));
            Movies.Add(new Movie("The Emperor's New Groove", 2000, "Animated"));
            Movies.Add(new Movie("Gone with the Wind", 1940, "Drama"));
            Movies.Add(new Movie("Shawshank Redemption", 1994, "Drama"));
            Movies.Add(new Movie("The Outsiders", 1983, "Drama"));
            Movies.Add(new Movie("Prometheus", 2012, "Sci-Fi"));
            Movies.Add(new Movie("Total Recall", 1990, "Sci-Fi"));
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i + 1}. {m.Title}, {m.Year}.");
            }
        }

        public void SearchGenre()
        {
            Movies.Sort((x, y) => x.Year.CompareTo(y.Year));
            //List<Movie> SortedMovies = Movies.OrderBy
            bool genSearch = false;
            while (genSearch == false)
            {
                Console.WriteLine("What category are you interested in? \n1.) Horror films 2.) Animated films 3.) Drama films 4.) Sci-Fi films");
                int catInput = int.Parse(Console.ReadLine());

                if (catInput == 1)
                {
                    Console.WriteLine("Here are the horror films:");
                    for (int i = 0; i < Movies.Count; i++)
                    {
                        Movie h = Movies[i];
                        if (h.Genre == "Horror")
                        {
                            Console.WriteLine($"\t{h.Title}, {h.Year}.");
                        }
                    }
                    Console.WriteLine();
                    Continue();
                }
                else if (catInput == 2)
                {
                    Console.WriteLine("Here are the animated films:");
                    for (int i = 0; i < Movies.Count; i++)
                    {
                        Movie a = Movies[i];
                        if (a.Genre == "Animated")
                        {
                            Console.WriteLine($"\t{a.Title}, {a.Year}.");
                        }
                    }
                    Console.WriteLine();
                    Continue();
                }
                else if (catInput == 3)
                {
                    Console.WriteLine("Here are the drama films:");
                    for (int i = 0; i < Movies.Count; i++)
                    {
                        Movie d = Movies[i];
                        if (d.Genre == "Drama")
                        {
                            Console.WriteLine($"\t{d.Title}, {d.Year}.");
                        }
                    }
                    Console.WriteLine();
                    Continue();
                }
                else if (catInput == 4)
                {
                    Console.WriteLine("Here are the sci-fi films:");
                    for (int i = 0; i < Movies.Count; i++)
                    {
                        Movie s = Movies[i];
                        if (s.Genre == "Sci-Fi")
                        {
                            Console.WriteLine($"\t{s.Title}, {s.Year}.");
                        }
                    }
                    Console.WriteLine();
                    Continue();
                }
                else
                {
                    Console.WriteLine("I'm sorry, You must only enter a number between 1-4.");
                    continue;
                }
            }
        }

        public void Continue()
        {
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("Would you like to search for another category of movies? y/n");
                string continueAnswer = Console.ReadLine().ToLower();
                if (continueAnswer == "y")
                {
                    SearchGenre();
                }
                else if (continueAnswer == "n")
                {
                    Console.WriteLine("Fine. Go and play a video game if you can't respect the brilliance of cinema.");
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't 'y' or 'n'. Try again:");
                    continue;
                }
            }
        }
    }
}
