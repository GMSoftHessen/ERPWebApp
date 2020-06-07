


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class UserBaseRepository
    {   
        
       internal DbContext _context { get; set; }
       internal DbSet<User> _dbSet  { get { return _context.Set<User>();  } }

        

        public IEnumerable<User> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<User> AllInclude
        (params Expression<Func<User, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<User> FindByInclude
          (Expression<Func<User, bool>> predicate,
          params Expression<Func<User, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<User> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<User> GetAllIncluding
        (params Expression<Func<User, object>>[] includeProperties)
        {
            IQueryable<User> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<User> FindBy(Expression<Func<User, bool>> predicate)
        {

            IEnumerable<User> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public User FindByKey(int id)
        {
            Expression<Func<User, bool>> lambda = Utilities.BuildLambdaForFindByKey<User>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(User entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(User entity)
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