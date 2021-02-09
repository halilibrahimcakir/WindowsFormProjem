using BarkotTakip.Data.Context;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BarkotTakip.Data.Repository
{
    public abstract class RepositoryBase<T> where T : class
    {
        private readonly MarketBarkodDBEntities _context;
        private readonly IDbSet<T> _dbSet;

        public RepositoryBase(MarketBarkodDBEntities context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public RepositoryBase()
        {
            _context = new MarketBarkodDBEntities();
            _dbSet = _context.Set<T>();
        }
        //Crud Create, read(get , getall), update,delete

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public virtual void Add(T entity)
        {
             _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
