using System.Linq;

namespace BlingBackend.Logic.Interfaces
{
    public interface ILogic<T>
    {
        int Create(T entity);
        T Get(int id);
        T Update(T entity);
        void Delete(int id);
        IQueryable<T> GetAll();
    }
}