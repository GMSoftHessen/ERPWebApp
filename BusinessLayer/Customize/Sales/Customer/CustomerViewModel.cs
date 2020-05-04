using BusinessLayer.Base;
using DataAccessLayer.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Customize
{
   
    public partial class CustomerViewModel 
    {
        #region newCustomer
        public Customer CreateNewCustomer()
        {
            Customer newCutomer = new Customer();

            return newCutomer;
        }

        #endregion
    }

}
