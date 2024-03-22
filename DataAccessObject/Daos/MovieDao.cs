using BussinessObject.Models;

namespace DataAccessObject.Daos
{
    public class MovieDao : GenericDao<Movie>
    {
        public MovieDao(PePrn23fallB5Context context) : base(context)
        {
        }
    }
}
