
using BusinessLayer.Base;
using DataAccessLayer.Admin;
using DataAccessLayer.Sales;

namespace BusinessLayer.Customize
{
    public partial class UserViewModel 
    {
        public User GetUser(string username)
        {
            return _userBO.GetUser(username);            
        }

    }

}
