using System;
using System.Collections.Generic;

namespace in_flight_movies
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1=new Movie("Miss Bala",104);
            Movie movie2=new Movie("Happy Death Day ",100);
            Movie movie3=new Movie("Captain Marvel",109);
            Movie movie4=new Movie("Wonder Park",95);
            Movie movie5=new Movie("Hellboy",120);
            Movie movie6=new Movie("Little",112);
            Movie movie7=new Movie("Long Shot",104);

            var movieList=new List<Movie>();
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);
            movieList.Add(movie7);

            

        }
    }
}
