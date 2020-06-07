
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class MenuBaseViewModel
    {
        #region private members
        private MenuBaseBO _MenuBaseBO;
        #endregion private members

        #region abfragen
        public MenuBaseViewModel(MenuBaseBO MenuBO)
        {
            _MenuBaseBO = MenuBO;
        }

        public List<Menu> GetAll()
        {
            return _MenuBaseBO.GetAll();
        }
        public Menu Find(int id)
        {
            return _MenuBaseBO.Find(id);
        }

        public int Insert(Menu Menu)
        {
            return _MenuBaseBO.Insert(Menu);
        }

        public void Update(Menu Menu)
        {
            _MenuBaseBO.Update(Menu);
        }

        public void Delete(int id)
        {
            _MenuBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
