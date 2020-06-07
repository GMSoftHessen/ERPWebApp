


namespace BusinessLayer.Customize
{
    public partial class CustomerViewModel 
    {
        CustomerBO _CustomercustomerBO;
        public CustomerViewModel(CustomerBO CustomerBO) 
        {
            _CustomerBO = CustomerBO;
        }
    }
}
