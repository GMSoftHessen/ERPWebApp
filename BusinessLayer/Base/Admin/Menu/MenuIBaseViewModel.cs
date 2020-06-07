
using DataAccessLayer.Admin;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface IMenuViewModel
    {
        List<Menu> GetAll();
        Menu Find(int id);
        void Update(Menu menu);
        int Insert(Menu menu);
        void Delete(int id);
     
    }
}