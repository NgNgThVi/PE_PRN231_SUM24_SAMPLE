namespace Repository.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T? GetById(int id);
        void Delete(T entity);
        void Update(T entity);
        void Add(T entity);
        int Save();
    }
}
