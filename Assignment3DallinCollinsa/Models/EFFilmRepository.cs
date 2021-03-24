using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3DallinCollinsa.Models
{
    public class EFFilmRepository : FilmRepository
    {

        private EFFilmRepository _context;

        //constructor to give the private variable a value
        public EFFilmRepository (FilmDBContext context)
        {
            _context = context;
        }

        public IQueryable<EnterMoviesModel> Filmes => _context.Filmes
    }
}
