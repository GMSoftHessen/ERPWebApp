
using BusinessLayer.Base;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;

namespace BusinessLayer.BO
{
    public abstract class CustomerBaseBO
    {
        private ICustomerRepository _ICustomerRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }


        public CustomerBaseBO(ICustomerRepository customerRepository)
        {
            _ICustomerRepository = customerRepository;
        }

        public List<Customer> GetAll()
        {
            try
            {
                using (_ICustomerRepository.DbContext = _DbContext)
                {
                    List<Customer> customers = _ICustomerRepository.All();
                }

                using (_ICustomerRepository.DbContext = _DbContext)
                {
                    List<Customer> customers = _ICustomerRepository.All();

                    return customers;
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
                using (_ICustomerRepository.DbContext = _DbContext)
                {
                    Customer customer = _ICustomerRepository.Find(id);

                    return customer;
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
                using (_ICustomerRepository.DbContext = _DbContext)
                {
                    _ICustomerRepository.Insert(customer);
                    _ICustomerRepository.DbContext.SaveChanges();
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
                using (_ICustomerRepository.DbContext = _DbContext)
                {
                    _ICustomerRepository.Update(customer);
                    _ICustomerRepository.DbContext.SaveChanges();
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
                using (_ICustomerRepository.DbContext = _DbContext)
                {
                    _ICustomerRepository.Delete(id);
                    _ICustomerRepository.DbContext.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


    }
}