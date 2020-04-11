using BusinessLayer.Base;
using DataAccessLayer.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Customize
{
    public partial  class CustomerViewModel : CustomerBaseViewModel, ICustomerViewModel
    {
        ICustomerBO _ICustomerBO;
        public CustomerViewModel(ICustomerBO customerBO) :base (customerBO)
        {
            _ICustomerBO = customerBO;
        }
    }

    
}
