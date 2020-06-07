

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
    public  class PermissionsBaseBO
    {
        public PermissionsBaseRepository _PermissionsBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public PermissionsBaseBO(PermissionsBaseRepository PermissionsRepository)
        {
            _PermissionsBaseRepository = PermissionsRepository;
        }


        public List<Permissions> GetAll()
        {
            try
            {
                using (_PermissionsBaseRepository._context = _DbContext)
                {
                    List<Permissions> Permissionss = _PermissionsBaseRepository.All().ToList();
                }

                using (_PermissionsBaseRepository._context = _DbContext)
                {
                    List<Permissions> result = _PermissionsBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Permissions Find(int id)
        {
            try
            {
                using (_PermissionsBaseRepository._context = _DbContext)
                {
                    Permissions result = _PermissionsBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Permissions Permissions)
        {
            try
            {
                using (_PermissionsBaseRepository._context = _DbContext)
                {
                    _PermissionsBaseRepository.Insert(Permissions);
                    _PermissionsBaseRepository._context.SaveChanges();
                    return Permissions.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Permissions Permissions)
        {
            try
            {
                using (_PermissionsBaseRepository._context = _DbContext)
                {
                    _PermissionsBaseRepository.Update(Permissions);
                    _PermissionsBaseRepository._context.SaveChanges();
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
                using (_PermissionsBaseRepository._context = _DbContext)
                {
                    _PermissionsBaseRepository.Delete(id);
                    _PermissionsBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}