using System.Linq;

namespace BlingBackend.Logic.Interfaces
{
    public interface ILogic<T>
    {
        int Create(T entity);
        T Get(int id);
        bool Update(T entity);
        bool Delete(int id);
        IQueryable<T> GetAll();
    }
}