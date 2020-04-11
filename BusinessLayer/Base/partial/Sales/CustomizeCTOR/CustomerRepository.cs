
using DataAccessLayer.Repository;
using DataAccessLayer.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Base;

namespace BusinessLayer.Customize
{
    public partial class CustomerRepository : CustomerBaseRepository, ICustomerRepository
    {
        ~CustomerRepository()
        {

        }

        #region private meber

        #endregion private meber

        #region ctr
        public CustomerRepository() :base(100)
            
        {
            
        }
        #endregion ctr

        #region ReadData
        #endregion  ReadData

        #region WriteData
        #endregion WriteData

    }
}
