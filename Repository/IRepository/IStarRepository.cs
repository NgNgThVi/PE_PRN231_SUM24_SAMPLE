using BussinessObject.Models;

namespace Repository.IRepository
{
    public interface IStarRepository : IGenericRepository<Star>
    {
        public Star? GetStarByIdIncludeMovice(int id);
    }
}
