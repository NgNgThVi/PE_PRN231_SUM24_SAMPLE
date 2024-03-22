using BussinessObject.Models;
using DataAccessObject;
using Repository.IRepository;

namespace Repository.Repository
{
    public class DirectorRepository : GenericRepository<Director>, IDirectorRepository
    {
        public DirectorRepository(GenericDao<Director> dao) : base(dao)
        {
        }
    }
}
