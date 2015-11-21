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

        public virtual int Create(T entity)
        {
            return _repository.Create(entity);
        }

        public T Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}