using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject.Daos
{
    public class GenreDao : GenericDao<Genre>
    {
        public GenreDao(PePrn23fallB5Context context) : base(context)
        {
        }
        public Genre? GetGenreByIdIncludeMovie(int id)
        {
            return _context.Genres.Where(x => x.Id == id).Include(x => x.Movies).FirstOrDefault();
        }
        public void DeleteRelationship(int genreid, int movieid)
        {
            var genre = _context.Genres.Where(x => x.Id == genreid).Include(x => x.Movies).FirstOrDefault();
            if (genre != null)
            {
                var movie = genre.Movies.Where(x => x.Id == movieid).FirstOrDefault();
                if (movie != null)
                {
                    genre.Movies.Remove(movie);
                    Save();
                }
            }
        }
    }
}
