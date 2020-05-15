using DataAccessLayer.Admin;
using System;
using System.Collections.Generic;

namespace BusinessLayer.BO
{
    public abstract class UserBaseBO
    {
        public IUserRepository _IUserRepository;

        public AdminDbContext _DbContext
        {
            get { return new AdminDbContext(); }

        }


        public UserBaseBO(IUserRepository userRepository)
        {
            _IUserRepository = userRepository;
        }

        public List<User> GetAll()
        {
            try
            {
                using (_IUserRepository.DbContext = _DbContext)
                {
                    List<User> customers = _IUserRepository.All();
                }

                using (_IUserRepository.DbContext = _DbContext)
                {
                    List<User> users = _IUserRepository.All();

                    return users;
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
                using (_IUserRepository.DbContext = _DbContext)
                {
                    User user = _IUserRepository.Find(id);

                    return user;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public int Insert(User user)
        {
            try
            {
                using (_IUserRepository.DbContext = _DbContext)
                {
                    _IUserRepository.Insert(user);
                    _IUserRepository.DbContext.SaveChanges();
                    return user.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public void Update(User user)
        {
            try
            {
                using (_IUserRepository.DbContext = _DbContext)
                {
                    _IUserRepository.Update(user);
                    _IUserRepository.DbContext.SaveChanges();
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
                using (_IUserRepository.DbContext = _DbContext)
                {
                    _IUserRepository.Delete(id);
                    _IUserRepository.DbContext.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


    }
}