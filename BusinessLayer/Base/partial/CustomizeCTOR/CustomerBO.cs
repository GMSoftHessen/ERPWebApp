using BusinessLayer.BO;
using BusinessLayer.Base;


namespace BusinessLayer.Customize
{
    public partial class CustomerBO : CustomerBaseBO, ICustomerBO
    {
        public CustomerBO(ICustomerRepository customerRepository) : base(customerRepository)
        {

        }

    }
}