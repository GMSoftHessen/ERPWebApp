
using BusinessLayer.BO;
using BusinessLayer.Base;
using DataAccessLayer.Admin;
using System;

namespace BusinessLayer.Customize
{
    public partial class UserBO 
    {

        public User GetUser(string username)
        {
            try
            {
                using (_IUserRepository.DbContext = _DbContext)
                {
                    User user = _IUserRepository.GetUser(username);

                    return user;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

    }
}