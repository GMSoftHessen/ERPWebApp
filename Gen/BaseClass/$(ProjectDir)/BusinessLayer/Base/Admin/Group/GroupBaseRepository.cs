


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class GroupBaseRepository
    {
        internal DbContext _context;
        internal DbSet<Group> _dbSet;
        
        internal DbContext _context { get; set; }
        internal DbSetGroup _dbSet { get { return _context.Set<Group>();  } }

        public GroupBaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Group>();
        }

        public IEnumerable<Group> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Group> AllInclude
        (params Expression<Func<Group, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Group> FindByInclude
          (Expression<Func<Group, bool>> predicate,
          params Expression<Func<Group, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Group> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Group> GetAllIncluding
        (params Expression<Func<Group, object>>[] includeProperties)
        {
            IQueryable<Group> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Group> FindBy(Expression<Func<Group, bool>> predicate)
        {

            IEnumerable<Group> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Group FindByKey(int id)
        {
            Expression<Func<Group, bool>> lambda = Utilities.BuildLambdaForFindByKey<Group>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Group entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Group entity)
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