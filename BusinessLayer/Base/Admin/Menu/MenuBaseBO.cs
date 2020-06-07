

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
    public  class MenuBaseBO
    {
        public MenuBaseRepository _MenuBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public MenuBaseBO(MenuBaseRepository MenuRepository)
        {
            _MenuBaseRepository = MenuRepository;
        }


        public List<Menu> GetAll()
        {
            try
            {
                using (_MenuBaseRepository._context = _DbContext)
                {
                    List<Menu> Menus = _MenuBaseRepository.All().ToList();
                }

                using (_MenuBaseRepository._context = _DbContext)
                {
                    List<Menu> result = _MenuBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Menu Find(int id)
        {
            try
            {
                using (_MenuBaseRepository._context = _DbContext)
                {
                    Menu result = _MenuBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Menu Menu)
        {
            try
            {
                using (_MenuBaseRepository._context = _DbContext)
                {
                    _MenuBaseRepository.Insert(Menu);
                    _MenuBaseRepository._context.SaveChanges();
                    return Menu.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Menu Menu)
        {
            try
            {
                using (_MenuBaseRepository._context = _DbContext)
                {
                    _MenuBaseRepository.Update(Menu);
                    _MenuBaseRepository._context.SaveChanges();
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
                using (_MenuBaseRepository._context = _DbContext)
                {
                    _MenuBaseRepository.Delete(id);
                    _MenuBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}