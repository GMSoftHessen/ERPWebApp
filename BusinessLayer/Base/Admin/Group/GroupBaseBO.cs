

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
    public  class GroupBaseBO
    {
        public GroupBaseRepository _GroupBaseRepository;

        public SalesDbContext _DbContext
        {
            get { return new SalesDbContext(); }

        }
        public GroupBaseBO(GroupBaseRepository GroupRepository)
        {
            _GroupBaseRepository = GroupRepository;
        }


        public List<Group> GetAll()
        {
            try
            {
                using (_GroupBaseRepository._context = _DbContext)
                {
                    List<Group> Groups = _GroupBaseRepository.All().ToList();
                }

                using (_GroupBaseRepository._context = _DbContext)
                {
                    List<Group> result = _GroupBaseRepository.All().ToList();

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        public Group Find(int id)
        {
            try
            {
                using (_GroupBaseRepository._context = _DbContext)
                {
                    Group result = _GroupBaseRepository.FindByKey(id);

                    return result;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public int Insert(Group Group)
        {
            try
            {
                using (_GroupBaseRepository._context = _DbContext)
                {
                    _GroupBaseRepository.Insert(Group);
                    _GroupBaseRepository._context.SaveChanges();
                    return Group.Id;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }



        public void Update(Group Group)
        {
            try
            {
                using (_GroupBaseRepository._context = _DbContext)
                {
                    _GroupBaseRepository.Update(Group);
                    _GroupBaseRepository._context.SaveChanges();
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
                using (_GroupBaseRepository._context = _DbContext)
                {
                    _GroupBaseRepository.Delete(id);
                    _GroupBaseRepository._context.SaveChanges();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}