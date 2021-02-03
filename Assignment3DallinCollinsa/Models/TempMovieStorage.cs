using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3DallinCollinsa.Models
{
    public class TempMovieStorage
    {
        private static List<EnterMoviesModel> movies = new List<EnterMoviesModel>();

        public static IEnumerable<EnterMoviesModel> Movies => movies;

        public static void AddApplication(EnterMoviesModel enterMovies)
        {
            movies.Add(enterMovies);
        }
    }
}
