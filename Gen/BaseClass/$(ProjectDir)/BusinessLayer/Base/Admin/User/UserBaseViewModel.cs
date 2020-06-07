
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class UserBaseViewModel
    {
        #region private members
        private UserBaseBO _UserBaseBO;
        #endregion private members

        #region abfragen
        public UserBaseViewModel(UserBaseBO UserBO)
        {
            _UserBaseBO = UserBO;
        }

        public List<User> GetAll()
        {
            return _UserBaseBO.GetAll();
        }
        public User Find(int id)
        {
            return _UserBaseBO.Find(id);
        }

        public int Insert(User User)
        {
            return _UserBaseBO.Insert(User);
        }

        public void Update(User User)
        {
            _UserBaseBO.Update(User);
        }

        public void Delete(int id)
        {
            _UserBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
