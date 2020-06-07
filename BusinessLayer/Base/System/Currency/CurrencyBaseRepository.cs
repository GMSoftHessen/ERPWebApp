


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.System;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class CurrencyBaseRepository
    {   
        
       internal DbContext _context { get; set; }
       internal DbSet<Currency> _dbSet  { get { return _context.Set<Currency>();  } }

        

        public IEnumerable<Currency> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Currency> AllInclude
        (params Expression<Func<Currency, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Currency> FindByInclude
          (Expression<Func<Currency, bool>> predicate,
          params Expression<Func<Currency, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Currency> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Currency> GetAllIncluding
        (params Expression<Func<Currency, object>>[] includeProperties)
        {
            IQueryable<Currency> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Currency> FindBy(Expression<Func<Currency, bool>> predicate)
        {

            IEnumerable<Currency> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Currency FindByKey(int id)
        {
            Expression<Func<Currency, bool>> lambda = Utilities.BuildLambdaForFindByKey<Currency>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Currency entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Currency entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = FindByKey(id);
            _dbSet.Remove(entity);
        }


    }


}