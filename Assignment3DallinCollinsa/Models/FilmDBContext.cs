using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3DallinCollinsa.Models
{
    //inherits from DbContext class
    public class FilmDBContext : DbContext
    {

        //inherits from base options

        public FilmDBContext (DbContextOptions<FilmDBContext> options) : base (options)
        {

        }

        //sets films
        public DbSet<EnterMoviesModel> Filmes { get; set; }
    }
}
