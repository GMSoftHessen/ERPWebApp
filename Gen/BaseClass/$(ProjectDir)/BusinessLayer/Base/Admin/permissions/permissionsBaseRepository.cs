


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class PermissionsBaseRepository
    {
        internal DbContext _context;
        internal DbSet<Permissions> _dbSet;
        
        internal DbContext _context { get; set; }
        internal DbSetPermissions _dbSet { get { return _context.Set<Permissions>();  } }

        public PermissionsBaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Permissions>();
        }

        public IEnumerable<Permissions> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Permissions> AllInclude
        (params Expression<Func<Permissions, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Permissions> FindByInclude
          (Expression<Func<Permissions, bool>> predicate,
          params Expression<Func<Permissions, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Permissions> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Permissions> GetAllIncluding
        (params Expression<Func<Permissions, object>>[] includeProperties)
        {
            IQueryable<Permissions> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Permissions> FindBy(Expression<Func<Permissions, bool>> predicate)
        {

            IEnumerable<Permissions> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Permissions FindByKey(int id)
        {
            Expression<Func<Permissions, bool>> lambda = Utilities.BuildLambdaForFindByKey<Permissions>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Permissions entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Permissions entity)
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