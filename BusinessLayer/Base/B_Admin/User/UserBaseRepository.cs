
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.Admin;


namespace BusinessLayer.Base
{
    public abstract class UserBaseRepository
    {
        public AdminDbContext DbContext { get; set; }

        int _CountOfMaxRows;
        public UserBaseRepository(int countOfMaxRows)
        {
            _CountOfMaxRows = countOfMaxRows;
            _CountOfMaxRows = 500;
        }

        #region GET

        public List<User> All()
        {
            return DbContext.Users.OrderBy(o => o.Id).Take(_CountOfMaxRows).AsNoTracking().ToList();
        }

        public IQueryable<User> AsIQueryableAll()
        {
            return DbContext.Users.OrderBy(o => o.Id).Take(_CountOfMaxRows).AsNoTracking().AsQueryable();
        }

        public IEnumerable<User> AsIEnumerableAll()
        {
            return DbContext.Users.OrderBy(o => o.Id).Take(_CountOfMaxRows).AsNoTracking().AsEnumerable();
        }


        #endregion GET

        #region CURD
        public User Find(int id)
        {
            User user = DbContext.Users.Find(id);

            if (user == null)
                user = new User();

            return user;
        }

        public void Insert(User user)
        {
            DbContext.Users.Add(user);
        }

        public void Update(User user)
        {
            DbContext.Users.Attach(user);
            DbContext.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = DbContext.Users.Find(id);

            if (user != null)
                DbContext.Users.Remove(user);
        }
        #endregion CURD

    }


}