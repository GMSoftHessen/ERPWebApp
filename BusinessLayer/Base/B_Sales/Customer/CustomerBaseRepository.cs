
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.Sales;


namespace BusinessLayer.Base
{
    public abstract class CustomerBaseRepository
    {
        public SalesDbContext DbContext { get; set; }

        int _CountOfMaxRows;
        public CustomerBaseRepository(int countOfMaxRows)
        {
            _CountOfMaxRows = countOfMaxRows;
            _CountOfMaxRows = 500;
        }

        #region GET

        public List<Customer> All()
        {
            return DbContext.Customers.OrderBy(o => o.Id).Take(_CountOfMaxRows).AsNoTracking().ToList();
        }

        public IQueryable<Customer> AsIQueryableAll()
        {
            return DbContext.Customers.OrderBy(o => o.Id).Take(_CountOfMaxRows).AsNoTracking().AsQueryable();
        }

        public IEnumerable<Customer> AsIEnumerableAll()
        {
            return DbContext.Customers.OrderBy(o => o.Id).Take(_CountOfMaxRows).AsNoTracking().AsEnumerable();
        }


        #endregion GET

        #region CURD
        public Customer Find(int id)
        {
            Customer customer = DbContext.Customers.Find(id);

            if (customer == null)
                customer = new Customer();

            return customer;
        }

        public void Insert(Customer customer)
        {
            DbContext.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            DbContext.Customers.Attach(customer);
            DbContext.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Customer customer = DbContext.Customers.Find(id);

            if (customer != null)
                DbContext.Customers.Remove(customer);
        }
        #endregion CURD

    }


}