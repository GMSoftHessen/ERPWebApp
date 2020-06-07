

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
    public  class CurrencyBaseBO
    {
        public CurrencyBaseRepository _CurrencyBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public CurrencyBaseBO(CurrencyBaseRepository CurrencyRepository)
        {
            _CurrencyBaseRepository = CurrencyRepository;
        }


        public List<Currency> GetAll()
        {
            try
            {
                using (_CurrencyBaseRepository._context = _DbContext)
                {
                    List<Currency> Currencys = _CurrencyBaseRepository.All().ToList();
                }

                using (_CurrencyBaseRepository._context = _DbContext)
                {
                    List<Currency> result = _CurrencyBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Currency Find(int id)
        {
            try
            {
                using (_CurrencyBaseRepository._context = _DbContext)
                {
                    Currency result = _CurrencyBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Currency Currency)
        {
            try
            {
                using (_CurrencyBaseRepository._context = _DbContext)
                {
                    _CurrencyBaseRepository.Insert(Currency);
                    _CurrencyBaseRepository._context.SaveChanges();
                    return Currency.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Currency Currency)
        {
            try
            {
                using (_CurrencyBaseRepository._context = _DbContext)
                {
                    _CurrencyBaseRepository.Update(Currency);
                    _CurrencyBaseRepository._context.SaveChanges();
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
                using (_CurrencyBaseRepository._context = _DbContext)
                {
                    _CurrencyBaseRepository.Delete(id);
                    _CurrencyBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}