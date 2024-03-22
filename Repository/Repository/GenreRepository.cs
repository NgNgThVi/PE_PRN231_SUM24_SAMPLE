using BussinessObject.Models;
using DataAccessObject;
using DataAccessObject.Daos;
using Repository.IRepository;

namespace Repository.Repository
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        private GenreDao _dao;
        public GenreRepository(GenericDao<Genre> dao) : base(dao)
        {
            _dao = new GenreDao(dao._context);
        }

        public void DeleteRelationship(int genreid, int movieid)
        {
            _dao.DeleteRelationship(genreid, movieid);
        }

        public Genre? GetGenreByIdIncludeMovie(int id)
        {
            return _dao.GetGenreByIdIncludeMovie(id);
        }
    }
}
