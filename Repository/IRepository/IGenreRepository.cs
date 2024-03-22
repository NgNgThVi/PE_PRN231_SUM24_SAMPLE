using BussinessObject.Models;

namespace Repository.IRepository
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        public Genre? GetGenreByIdIncludeMovie(int id);
        public void DeleteRelationship(int genreid, int movieid);
    }
}
