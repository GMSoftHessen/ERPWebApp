
using BusinessLayer.Base;
using DataAccessLayer.Sales;

namespace BusinessLayer.Customize
{
    public partial class CustomerViewModel : CustomerBaseViewModel, ICustomerViewModel
    {
        ICustomerBO _ICustomerBO;
        public CustomerViewModel(ICustomerBO customerBO) : base(customerBO)
        {
            _ICustomerBO = customerBO;
        }
    }

}
