using BussinessObject.Models;
using DataAccessObject;
using DataAccessObject.Daos;
using Repository.IRepository;

namespace Repository.Repository
{
    public class StarRepository : GenericRepository<Star>, IStarRepository
    {
        private StarDao _starDao;
        public StarRepository(GenericDao<Star> dao) : base(dao)
        {
            _starDao = new StarDao(dao._context);
        }

        public Star? GetStarByIdIncludeMovice(int id)
        {
            return _starDao.GetStarByIdIncludeMovice(id);
        }
    }
}
