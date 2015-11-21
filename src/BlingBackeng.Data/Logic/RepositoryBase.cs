using BlingBackend.Model;
using BlingBackeng.Data.Interface;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace BlingBackeng.Data.Logic
{
    public abstract class RepositoryBase<T> : IRepository<T>
        where T : class, IEntity
    {
        private readonly BlingBackendDbContext _dbContext;

        protected RepositoryBase(BlingBackendDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");

            _dbContext = dbContext;
        }

        public T Create(T entity)
        {
            T addedEntity = _dbContext.Set<T>().Add(entity);

            //            DbEntityEntry < T> entityToCreate = _dbContext.Entry(entity);
            //            entityToCreate.State = EntityState.Added;
            //            _dbContext.Set<T>().
            _dbContext.SaveChanges();
            return addedEntity;
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>()
                .FirstOrDefault(e => e.Id == id);
        }

        public T Update(T entity)
        {
            //            _dbContext.Set<T>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            T entity = Get(id);
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}