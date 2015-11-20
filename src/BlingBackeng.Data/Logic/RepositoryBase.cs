using System.Linq;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public abstract class RepositoryBase<T> : IRepository<T>
    {
        public T Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}