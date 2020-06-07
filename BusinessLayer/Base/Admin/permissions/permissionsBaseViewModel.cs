
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class PermissionsBaseViewModel:IPermissionsViewModel
    {
        #region private members
        private PermissionsBaseBO _PermissionsBaseBO;
        #endregion private members

        #region abfragen
        public PermissionsBaseViewModel(PermissionsBaseBO PermissionsBO)
        {
            _PermissionsBaseBO = PermissionsBO;
        }

        public List<Permissions> GetAll()
        {
            return _PermissionsBaseBO.GetAll();
        }
        public Permissions Find(int id)
        {
            return _PermissionsBaseBO.Find(id);
        }

        public int Insert(Permissions Permissions)
        {
            return _PermissionsBaseBO.Insert(Permissions);
        }

        public void Update(Permissions Permissions)
        {
            _PermissionsBaseBO.Update(Permissions);
        }

        public void Delete(int id)
        {
            _PermissionsBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
