using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.edmx;



namespace DataAccessLayer.Repository
{
    public abstract class CustomerBaseRepository 
    {      
        public ChinookDbContext DbContext { get; set; }       

        int _CountOfMaxRows;
        public CustomerBaseRepository(int countOfMaxRows)
        {
            _CountOfMaxRows = countOfMaxRows;
        }

        #region GET
        //_context.Customer.OrderBy( o => o.CustomerId).Skip(s => 20).Take(10).ToList();
        public List<Customer> All()
        {
            return DbContext.Customer.OrderBy( o => o.CustomerId).Take(500).AsNoTracking().ToList();
        }

        public IQueryable<Customer> AsIQueryableAll()
        {
            return DbContext.Customer.OrderBy(o => o.CustomerId).Take(_CountOfMaxRows).AsNoTracking().AsQueryable();
        }

        public IEnumerable<Customer> AsIEnumerableAll()
        {
            return DbContext.Customer.OrderBy(o => o.CustomerId).Take(_CountOfMaxRows ).AsNoTracking().AsEnumerable();
        }

        public List<Customer> EagerAll()
        {            ////_context.La = false;
            List<Customer> customers = DbContext.Customer.ToList();

            //_context.LazyLoadingEnabled = true;

            if (customers == null)
                customers = new List<Customer>();

            return customers;
        }

        public string GetNextCustomerNumber()
        {
            var nextvalue = DbContext.GetNextCustomerNumberSequenceValue();
            long? nextSequenceValue = nextvalue.Single();

            return nextSequenceValue.ToString();
        }
        #endregion GET

        #region CURD
        public Customer Find(int id)
        {
            Customer customer = DbContext.Customer.Find(id);

            if (customer == null)
                customer = new Customer();

            return customer;
        }

        public void Insert(Customer customer)
        {
            DbContext.Customer.Add(customer);          
        }

        public void Update(Customer customer)
        {
            DbContext.Customer.Attach(customer);
            DbContext.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Customer customer = DbContext.Customer.Find(id);
            DbContext.Customer.Remove(customer);
        }
        #endregion CURD

    }


}
