
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
        public CustomerBaseRepository _customerBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public CustomerBaseBO(CustomerBaseRepository customerRepository)
        {
            _customerBaseRepository = customerRepository;
        }


        public List<Customer> GetAll()
        {
            try
            {
                using (_customerBaseRepository._context = _DbContext)
                {
                    List<Customer> customers = _customerBaseRepository.All().ToList();
                }

                using (_customerBaseRepository._context = _DbContext)
                {
                    List<Customer> result = _customerBaseRepository.All().ToList();

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
                using (_customerBaseRepository._context = _DbContext)
                {
                    Customer result = _customerBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Customer customer)
        {
            try
            {
                using (_customerBaseRepository._context = _DbContext)
                {
                    _customerBaseRepository.Insert(customer);
                    _customerBaseRepository._context.SaveChanges();
                    return customer.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Customer customer)
        {
            try
            {
                using (_customerBaseRepository._context = _DbContext)
                {
                    _customerBaseRepository.Update(customer);
                    _customerBaseRepository._context.SaveChanges();
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
                using (_customerBaseRepository._context = _DbContext)
                {
                    _customerBaseRepository.Delete(id);
                    _customerBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}