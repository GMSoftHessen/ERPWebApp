

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
    public  class CurrenciesBaseBO
    {
        public CurrenciesBaseRepository _CurrenciesBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public CurrenciesBaseBO(CurrenciesBaseRepository CurrenciesRepository)
        {
            _CurrenciesBaseRepository = CurrenciesRepository;
        }


        public List<Currencies> GetAll()
        {
            try
            {
                using (_CurrenciesBaseRepository._context = _DbContext)
                {
                    List<Currencies> Currenciess = _CurrenciesBaseRepository.All().ToList();
                }

                using (_CurrenciesBaseRepository._context = _DbContext)
                {
                    List<Currencies> result = _CurrenciesBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Currencies Find(int id)
        {
            try
            {
                using (_CurrenciesBaseRepository._context = _DbContext)
                {
                    Currencies result = _CurrenciesBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Currencies Currencies)
        {
            try
            {
                using (_CurrenciesBaseRepository._context = _DbContext)
                {
                    _CurrenciesBaseRepository.Insert(Currencies);
                    _CurrenciesBaseRepository._context.SaveChanges();
                    return Currencies.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Currencies Currencies)
        {
            try
            {
                using (_CurrenciesBaseRepository._context = _DbContext)
                {
                    _CurrenciesBaseRepository.Update(Currencies);
                    _CurrenciesBaseRepository._context.SaveChanges();
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
                using (_CurrenciesBaseRepository._context = _DbContext)
                {
                    _CurrenciesBaseRepository.Delete(id);
                    _CurrenciesBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}