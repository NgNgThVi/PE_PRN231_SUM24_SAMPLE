using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject.Daos
{
    public class StarDao : GenericDao<Star>
    {
        public StarDao(PePrn23fallB5Context context) : base(context)
        {
        }
        public Star? GetStarByIdIncludeMovice(int id)
        {
            return _context.Stars.Where(x => x.Id == id).Include(x => x.Movies).FirstOrDefault();
        }
    }
}
