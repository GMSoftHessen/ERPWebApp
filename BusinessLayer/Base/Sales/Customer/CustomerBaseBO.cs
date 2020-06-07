

using BusinessLayer.Base;
using DataAccessLayer.Sales;
using ReusableGenericRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLayer.BO
{
    public  class CustomerBaseBO
    {
        public CustomerBaseRepository _CustomerBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public CustomerBaseBO(CustomerBaseRepository CustomerRepository)
        {
            _CustomerBaseRepository = CustomerRepository;
        }


        public List<Customer> GetAll()
        {
            try
            {
                using (_CustomerBaseRepository._context = _DbContext)
                {
                    List<Customer> Customers = _CustomerBaseRepository.All().ToList();
                }

                using (_CustomerBaseRepository._context = _DbContext)
                {
                    List<Customer> result = _CustomerBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Customer Find(int id)
        {
            try
            {
                using (_CustomerBaseRepository._context = _DbContext)
                {
                    Customer result = _CustomerBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Customer Customer)
        {
            try
            {
                using (_CustomerBaseRepository._context = _DbContext)
                {
                    _CustomerBaseRepository.Insert(Customer);
                    _CustomerBaseRepository._context.SaveChanges();
                    return Customer.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Customer Customer)
        {
            try
            {
                using (_CustomerBaseRepository._context = _DbContext)
                {
                    _CustomerBaseRepository.Update(Customer);
                    _CustomerBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public void Delete(int id)
        {
            try
            {
                using (_CustomerBaseRepository._context = _DbContext)
                {
                    _CustomerBaseRepository.Delete(id);
                    _CustomerBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}