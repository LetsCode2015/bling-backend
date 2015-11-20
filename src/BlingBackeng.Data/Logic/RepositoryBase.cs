﻿using BlingBackeng.Data.Interface;
using System;
using System.Linq;

namespace BlingBackeng.Data.Logic
{
    public abstract class RepositoryBase<T> : IRepository<T>
        where T : class
    {
        private readonly BlingBackendDbContext _dbContext;

        protected RepositoryBase(BlingBackendDbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            _dbContext = dbContext;
        }

        public T Create(T entity)
        {
            _dbContext.Entry<T>(entity);
            return entity;
        }

        public T Get(int id)
        {
            _dbContext.Entry()
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