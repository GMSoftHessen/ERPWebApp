
using DataAccessLayer.Admin;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface IPermissionsViewModel
    {
        List<Permissions> GetAll();
        Permissions Find(int id);
        void Update(Permissions permissions);
        int Insert(Permissions permissions);
        void Delete(int id);
     
    }
}