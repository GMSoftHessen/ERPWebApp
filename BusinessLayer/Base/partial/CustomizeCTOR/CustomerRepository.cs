
using BusinessLayer.Base;

namespace BusinessLayer.Customize
{
    public partial class CustomerRepository : CustomerBaseRepository, ICustomerRepository
    {
        #region ctr
        public CustomerRepository() :base(500)
            
        {
            
        }
        #endregion ctr
    }
}