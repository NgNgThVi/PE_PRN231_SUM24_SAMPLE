using BussinessObject.Models;

namespace DataAccessObject.Daos
{
    public class DirectorDao : GenericDao<Director>
    {
        public DirectorDao(PePrn23fallB5Context context) : base(context)
        {
        }
    }
}
