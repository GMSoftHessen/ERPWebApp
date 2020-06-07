

namespace BusinessLayer.Customize
{
    public class CustomerBO
    {
        CustomerRepository _CustomerRepository;
    public CustomerBO(CustomerRepository CustomerRepository) 
        {
            _CustomerRepository = CustomerRepository;
        }
    }
}