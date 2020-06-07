
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class CustomerBaseRepository
    {
        internal DbContext _context;
        internal DbSet<Customer> _dbSet;

        public CustomerBaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Customer>();
        }

        public IEnumerable<Customer> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Customer> AllInclude
        (params Expression<Func<Customer, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Customer> FindByInclude
          (Expression<Func<Customer, bool>> predicate,
          params Expression<Func<Customer, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Customer> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Customer> GetAllIncluding
        (params Expression<Func<Customer, object>>[] includeProperties)
        {
            IQueryable<Customer> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Customer> FindBy(Expression<Func<Customer, bool>> predicate)
        {

            IEnumerable<Customer> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Customer FindByKey(int id)
        {
            Expression<Func<Customer, bool>> lambda = Utilities.BuildLambdaForFindByKey<Customer>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Customer entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Customer entity)
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