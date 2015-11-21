using System.Linq;

namespace BlingBackeng.Data.Interface
{
    public interface IRepository<T>
    {
        int Create(T entity);
        T Get(int id);
        bool Update(T entity);
        bool Delete(int id);
        IQueryable<T> GetAll();
    }
}