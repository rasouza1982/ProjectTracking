using System;
using System.Collections.Generic;

namespace ProjectTracking.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);


    }
}