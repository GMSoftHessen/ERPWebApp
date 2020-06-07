


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Sales;
using ReusableGenericRepository;

namespace BusinessLayer.Base
{
    public  class ProductBaseRepository
    {
        internal DbContext _context;
        internal DbSet<Product> _dbSet;
        
        internal DbContext _context { get; set; }
        internal DbSetProduct _dbSet { get { return _context.Set<Product>();  } }

        public ProductBaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Product>();
        }

        public IEnumerable<Product> All()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Product> AllInclude
        (params Expression<Func<Product, object>>[] includeProperties)
        {
            return GetAllIncluding(includeProperties).ToList();
        }

        public IEnumerable<Product> FindByInclude
          (Expression<Func<Product, bool>> predicate,
          params Expression<Func<Product, object>>[] includeProperties)
        {
            var query = GetAllIncluding(includeProperties);
            IEnumerable<Product> results = query.Where(predicate).ToList();
            return results;
        }

        private IQueryable<Product> GetAllIncluding
        (params Expression<Func<Product, object>>[] includeProperties)
        {
            IQueryable<Product> queryable = _dbSet.AsNoTracking();

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<Product> FindBy(Expression<Func<Product, bool>> predicate)
        {

            IEnumerable<Product> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();
            return results;
        }

        public Product FindByKey(int id)
        {
            Expression<Func<Product, bool>> lambda = Utilities.BuildLambdaForFindByKey<Product>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public void Insert(Product entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Product entity)
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