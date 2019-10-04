using System;
using System.Collections.Generic;
using System.Linq;

namespace in_flight_movies
{
    class Program
    {
      static List<Movie> nextMovieList = new List<Movie>();
            static void Main(string[] args)
            {
                List<Movie> movieList = new List<Movie>();

                Movie movie1 = new Movie
                {
                    Title = "Miss Bala",
                    Runtime = 87

                };
                Movie movie2 = new Movie
                {
                    Title = "Happy Death Day",
                    Runtime = 90

                };
                Movie movie3 = new Movie
                {
                    Title = "Captain Marvel",
                    Runtime = 120

                };
                Movie movie4 = new Movie
                {
                    Title = "Wonder Park",
                    Runtime = 95

                };

                movieList.Add(movie1);
                movieList.Add(movie2);
                movieList.Add(movie3);
                movieList.Add(movie4);
            Console.WriteLine("Please select which movie you want to watch:");
            Console.WriteLine();
                foreach (var movie in movieList.Select((Value, Index) => new { Value, Index }))
                {
                    Console.WriteLine("{0}). {1} minutes", movie.Index+1, movie.Value.ToString());

                }
                int input = Convert.ToInt16(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        nextMovieList = NextMovie(200, movie1, movieList);
                        if (nextMovieList.Any())
                        {
                            Console.WriteLine("Next Movie List:");
                            Console.WriteLine();

                        foreach (var movie in nextMovieList.Select((Value, Index) => new { Value, Index }))
                        {
                            Console.WriteLine("{0}). {1} minutes", movie.Index + 1, movie.Value.ToString());

                        }
                        
                        }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }


                        break;
                    case 2:
                        nextMovieList = NextMovie(200, movie2, movieList);
                        if (nextMovieList.Any())
                        {
                            Console.WriteLine("List of movies to watch next:");
                            Console.WriteLine();
                        foreach (var movie in nextMovieList.Select((Value, Index) => new { Value, Index }))
                        {
                            Console.WriteLine("{0}). {1} minutes", movie.Index + 1, movie.Value.ToString());

                        }
                    }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }

                        break;
                    case 3:
                        nextMovieList = NextMovie(200, movie3, movieList);
                        if (nextMovieList.Any())
                        {
                            Console.WriteLine("List of movies to watch next:");
                            Console.WriteLine();
                        foreach (var movie in nextMovieList.Select((Value, Index) => new { Value, Index }))
                        {
                            Console.WriteLine("{0}). {1} minutes", movie.Index + 1, movie.Value.ToString());

                        }
                    }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }

                        break;
                    case 4:
                        nextMovieList = NextMovie(200, movie4, movieList);
                        if (nextMovieList.Any())
                        {
                            Console.WriteLine("List of movies to watch next:");
                            Console.WriteLine();
                        foreach (var movie in nextMovieList.Select((Value, Index) => new { Value, Index }))
                        {
                            Console.WriteLine("{0}). {1} minutes", movie.Index + 1, movie.Value.ToString());

                        }
                    }
                        else
                        {
                            Console.WriteLine("Movie not found");
                        }

                        break;

                }
                Console.ReadKey(true);

            }
            public static List<Movie> NextMovie(int flightLength, Movie movie, List<Movie> movieList)
            {
                List<Movie> nextMovieList = new List<Movie>();
                int remainingTime = flightLength - movie.Runtime;
                movieList.Remove(movie);
                foreach (var nextmovie in movieList)
                {
                    if (remainingTime > nextmovie.Runtime)
                    {
                        nextMovieList.Add(nextmovie);

                    }
                }

                return nextMovieList;
            }
    }
}
