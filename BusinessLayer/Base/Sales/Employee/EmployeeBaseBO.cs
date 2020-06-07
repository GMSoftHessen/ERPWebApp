

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
    public  class EmployeeBaseBO
    {
        public EmployeeBaseRepository _EmployeeBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public EmployeeBaseBO(EmployeeBaseRepository EmployeeRepository)
        {
            _EmployeeBaseRepository = EmployeeRepository;
        }


        public List<Employee> GetAll()
        {
            try
            {
                using (_EmployeeBaseRepository._context = _DbContext)
                {
                    List<Employee> Employees = _EmployeeBaseRepository.All().ToList();
                }

                using (_EmployeeBaseRepository._context = _DbContext)
                {
                    List<Employee> result = _EmployeeBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Employee Find(int id)
        {
            try
            {
                using (_EmployeeBaseRepository._context = _DbContext)
                {
                    Employee result = _EmployeeBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Employee Employee)
        {
            try
            {
                using (_EmployeeBaseRepository._context = _DbContext)
                {
                    _EmployeeBaseRepository.Insert(Employee);
                    _EmployeeBaseRepository._context.SaveChanges();
                    return Employee.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Employee Employee)
        {
            try
            {
                using (_EmployeeBaseRepository._context = _DbContext)
                {
                    _EmployeeBaseRepository.Update(Employee);
                    _EmployeeBaseRepository._context.SaveChanges();
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
                using (_EmployeeBaseRepository._context = _DbContext)
                {
                    _EmployeeBaseRepository.Delete(id);
                    _EmployeeBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}