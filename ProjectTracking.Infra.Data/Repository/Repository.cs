using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectTracking.Domain.Interfaces.Repositories;

namespace ProjectTracking.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _db;

        public Repository(DbContext context)
        {
            _db = context.Set<TEntity>();
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.ToList();
        }

        public TEntity Get(int id)
        {
            return _db.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _db.Add(entity);
        }

        public void Update(TEntity entity)
        {
            var entry = _context.Entry(entity);
            _db.Attach(entity);
            entry.State= EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _db.Remove(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}