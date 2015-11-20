using System.Linq;

namespace BlingBackend.Logic.Interfaces
{
    public interface ILogic<T>
    {
        T Create(T entity);
        T Get(int id);
        T Update(T entity);
        T Delete(int id);
        IQueryable<T> GetAll();
    }
}