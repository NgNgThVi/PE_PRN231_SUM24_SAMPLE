using DataAccessObject;
using Repository.IRepository;

namespace Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private GenericDao<T> _dao;

        public GenericRepository(GenericDao<T> dao)
        {
            _dao = dao;
        }

        public void Add(T entity)
        {
            _dao.Add(entity);
        }

        public void Delete(T entity)
        {
            _dao.Delete(entity);
        }

        public List<T> GetAll()
        {
            return _dao.GetAll();
        }

        public T? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public int Save()
        {
            return (_dao.Save());
        }

        public void Update(T entity)
        {
            _dao.Update(entity);
        }
    }
}
