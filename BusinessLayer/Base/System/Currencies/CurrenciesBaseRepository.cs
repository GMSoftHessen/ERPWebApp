


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class CurrenciesBaseRepository
    {   
        
       internal DbContext _context { get; set; }
       internal DbSet<Currencies> _dbSet  { get { return _context.Set<Currencies>();  } }

        

        public IEnumerable<Currencies> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Currencies> AllInclude
        (params Expression<Func<Currencies, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Currencies> FindByInclude
          (Expression<Func<Currencies, bool>> predicate,
          params Expression<Func<Currencies, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Currencies> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Currencies> GetAllIncluding
        (params Expression<Func<Currencies, object>>[] includeProperties)
        {
            IQueryable<Currencies> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Currencies> FindBy(Expression<Func<Currencies, bool>> predicate)
        {

            IEnumerable<Currencies> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Currencies FindByKey(int id)
        {
            Expression<Func<Currencies, bool>> lambda = Utilities.BuildLambdaForFindByKey<Currencies>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Currencies entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Currencies entity)
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