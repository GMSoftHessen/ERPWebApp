


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Admin;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class permissionsBaseRepository
    {   
        
       internal DbContext _context { get; set; }
       internal DbSet<permissions> _dbSet  { get { return _context.Set<permissions>();  } }

        

        public IEnumerable<permissions> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<permissions> AllInclude
        (params Expression<Func<permissions, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<permissions> FindByInclude
          (Expression<Func<permissions, bool>> predicate,
          params Expression<Func<permissions, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<permissions> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<permissions> GetAllIncluding
        (params Expression<Func<permissions, object>>[] includeProperties)
        {
            IQueryable<permissions> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<permissions> FindBy(Expression<Func<permissions, bool>> predicate)
        {

            IEnumerable<permissions> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public permissions FindByKey(int id)
        {
            Expression<Func<permissions, bool>> lambda = Utilities.BuildLambdaForFindByKey<permissions>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(permissions entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(permissions entity)
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