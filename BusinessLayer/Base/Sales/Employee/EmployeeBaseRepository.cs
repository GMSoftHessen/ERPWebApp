


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class EmployeeBaseRepository
    {   
        
       internal DbContext _context { get; set; }
       internal DbSet<Employee> _dbSet  { get { return _context.Set<Employee>();  } }

        

        public IEnumerable<Employee> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Employee> AllInclude
        (params Expression<Func<Employee, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Employee> FindByInclude
          (Expression<Func<Employee, bool>> predicate,
          params Expression<Func<Employee, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Employee> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Employee> GetAllIncluding
        (params Expression<Func<Employee, object>>[] includeProperties)
        {
            IQueryable<Employee> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Employee> FindBy(Expression<Func<Employee, bool>> predicate)
        {

            IEnumerable<Employee> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Employee FindByKey(int id)
        {
            Expression<Func<Employee, bool>> lambda = Utilities.BuildLambdaForFindByKey<Employee>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Employee entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Employee entity)
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