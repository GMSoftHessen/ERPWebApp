
using DataAccessLayer.Admin;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface IGroupViewModel
    {
        List<Group> GetAll();
        Group Find(int id);
        void Update(Group group);
        int Insert(Group group);
        void Delete(int id);
     
    }
}