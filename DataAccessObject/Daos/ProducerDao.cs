using BussinessObject.Models;

namespace DataAccessObject.Daos
{
    public class ProducerDao : GenericDao<Producer>
    {
        public ProducerDao(PePrn23fallB5Context context) : base(context)
        {
        }
    }
}
