


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class MenuBaseRepository
    {   
        
       internal DbContext _context { get; set; }
       internal DbSet<Menu> _dbSet  { get { return _context.Set<Menu>();  } }

        

        public IEnumerable<Menu> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Menu> AllInclude
        (params Expression<Func<Menu, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Menu> FindByInclude
          (Expression<Func<Menu, bool>> predicate,
          params Expression<Func<Menu, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Menu> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Menu> GetAllIncluding
        (params Expression<Func<Menu, object>>[] includeProperties)
        {
            IQueryable<Menu> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Menu> FindBy(Expression<Func<Menu, bool>> predicate)
        {

            IEnumerable<Menu> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Menu FindByKey(int id)
        {
            Expression<Func<Menu, bool>> lambda = Utilities.BuildLambdaForFindByKey<Menu>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Menu entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Menu entity)
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