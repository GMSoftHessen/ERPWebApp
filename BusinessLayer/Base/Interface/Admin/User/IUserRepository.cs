
using DataAccessLayer.Admin;
using System.Collections.Generic;

namespace BusinessLayer
{
    public partial interface IUserRepository
    {
        AdminDbContext DbContext { get; set; }
        List<User> All();
        User Find(int id);
        void Delete(int id);
        void Update(User user);
        void Insert(User user);
        User GetUser(string username);        
    }
}