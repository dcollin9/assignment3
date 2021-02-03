using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3DallinCollinsa.Models
{
    public static class TempMovieStorage
    {

        //creates list that will persist while the program runs
        private static List<EnterMoviesModel> movies = new List<EnterMoviesModel>();

        //makes the list enumerable
        public static IEnumerable<EnterMoviesModel> Movies => movies;

        //adding an application to the list
        public static void AddApplication(EnterMoviesModel enterMovies)
        {
            movies.Add(enterMovies);
        }
    }
}
