
using BusinessLayer.Base;
using DataAccessLayer.Admin;
using System.Linq;

namespace BusinessLayer.Customize
{
    public partial class UserRepository
    {
        /// <summary>
        /// Liefert den User Zurück, der diese Username gehört. 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User GetUser(string username)
        {
          User user =  DbContext.Users.Where(u => u.UserName == username).FirstOrDefault();
          return user;
        }
    }
} 