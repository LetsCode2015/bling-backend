using System.Linq;

namespace BlingBackeng.Data.Interface
{
    public interface IRepository<T>
    {
        T Create(T entity);
        T Get(int id);
        T Update(T entity);
        T Delete(int id);
        IQueryable<T> GetAll();
    }
}