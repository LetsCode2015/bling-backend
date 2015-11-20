using System.Linq;
using BlingBackend.Logic.Interfaces;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public abstract class LogicBase<T> : ILogic<T>
    {
        private readonly IRepository<T> _repository;

        protected LogicBase(IRepository<T> repository)
        {
            _repository = repository;
        }

        public int Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}