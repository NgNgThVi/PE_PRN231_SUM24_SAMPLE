using BussinessObject.Models;
using DataAccessObject;
using Repository.IRepository;

namespace Repository.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(GenericDao<Movie> dao) : base(dao)
        {
        }
    }
}
