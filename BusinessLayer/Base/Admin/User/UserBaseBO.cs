

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
    public  class UserBaseBO
    {
        public UserBaseRepository _UserBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public UserBaseBO(UserBaseRepository UserRepository)
        {
            _UserBaseRepository = UserRepository;
        }


        public List<User> GetAll()
        {
            try
            {
                using (_UserBaseRepository._context = _DbContext)
                {
                    List<User> Users = _UserBaseRepository.All().ToList();
                }

                using (_UserBaseRepository._context = _DbContext)
                {
                    List<User> result = _UserBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public User Find(int id)
        {
            try
            {
                using (_UserBaseRepository._context = _DbContext)
                {
                    User result = _UserBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(User User)
        {
            try
            {
                using (_UserBaseRepository._context = _DbContext)
                {
                    _UserBaseRepository.Insert(User);
                    _UserBaseRepository._context.SaveChanges();
                    return User.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(User User)
        {
            try
            {
                using (_UserBaseRepository._context = _DbContext)
                {
                    _UserBaseRepository.Update(User);
                    _UserBaseRepository._context.SaveChanges();
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
                using (_UserBaseRepository._context = _DbContext)
                {
                    _UserBaseRepository.Delete(id);
                    _UserBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}