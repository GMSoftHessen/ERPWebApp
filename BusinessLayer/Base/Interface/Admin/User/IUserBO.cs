
using DataAccessLayer.Admin;
using System.Collections.Generic;

namespace BusinessLayer
{
    public partial interface IUserBO
    {
        List<User> GetAll();
        User Find(int id);
        void Update(User user);
        int Insert(User user);
        User GetUser(string username);
        void Delete(int id);

    }
}