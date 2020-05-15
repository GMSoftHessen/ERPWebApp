
using BusinessLayer.BO;
using DataAccessLayer.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public abstract class UserBaseViewModel
    {
        #region abfragen
        public UserBaseViewModel(IUserBO userBO)
        {
            _userBO = userBO;
        }

        public List<User> GetAll()
        {
            return _userBO.GetAll();
        }
        public User Find(int id)
        {
            return _userBO.Find(id);
        }

        public int Insert(User user)
        {
            return _userBO.Insert(user);
        }

        public void Update(User user)
        {
            _userBO.Update(user);
        }

        public void Delete(int id)
        {
            _userBO.Delete(id);
        }
        #endregion abfragen

        #region private members
        public IUserBO _userBO;
        #endregion private members
    }
}
