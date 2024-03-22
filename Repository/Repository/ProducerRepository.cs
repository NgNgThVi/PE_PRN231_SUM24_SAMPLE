using BussinessObject.Models;
using DataAccessObject;
using Repository.IRepository;

namespace Repository.Repository
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(GenericDao<Producer> dao) : base(dao)
        {
        }
    }
}
