
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class GroupBaseViewModel
    {
        #region private members
        private GroupBaseBO _GroupBaseBO;
        #endregion private members

        #region abfragen
        public GroupBaseViewModel(GroupBaseBO GroupBO)
        {
            _GroupBaseBO = GroupBO;
        }

        public List<Group> GetAll()
        {
            return _GroupBaseBO.GetAll();
        }
        public Group Find(int id)
        {
            return _GroupBaseBO.Find(id);
        }

        public int Insert(Group Group)
        {
            return _GroupBaseBO.Insert(Group);
        }

        public void Update(Group Group)
        {
            _GroupBaseBO.Update(Group);
        }

        public void Delete(int id)
        {
            _GroupBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
