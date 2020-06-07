

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
    public  class ProductBaseBO
    {
        public ProductBaseRepository _ProductBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public ProductBaseBO(ProductBaseRepository ProductRepository)
        {
            _ProductBaseRepository = ProductRepository;
        }


        public List<Product> GetAll()
        {
            try
            {
                using (_ProductBaseRepository._context = _DbContext)
                {
                    List<Product> Products = _ProductBaseRepository.All().ToList();
                }

                using (_ProductBaseRepository._context = _DbContext)
                {
                    List<Product> result = _ProductBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Product Find(int id)
        {
            try
            {
                using (_ProductBaseRepository._context = _DbContext)
                {
                    Product result = _ProductBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Product Product)
        {
            try
            {
                using (_ProductBaseRepository._context = _DbContext)
                {
                    _ProductBaseRepository.Insert(Product);
                    _ProductBaseRepository._context.SaveChanges();
                    return Product.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Product Product)
        {
            try
            {
                using (_ProductBaseRepository._context = _DbContext)
                {
                    _ProductBaseRepository.Update(Product);
                    _ProductBaseRepository._context.SaveChanges();
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
                using (_ProductBaseRepository._context = _DbContext)
                {
                    _ProductBaseRepository.Delete(id);
                    _ProductBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}