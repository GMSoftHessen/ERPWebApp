
using DataAccessLayer.Admin;
using System.Collections.Generic;

namespace BusinessLayer
{
    public partial interface IUserViewModel
    {
        List<User> GetAll();
        User Find(int id);
        void Update(User user);
        int Insert(User user);
        void Delete(int id);
        User GetUser(string userName);
    }
}