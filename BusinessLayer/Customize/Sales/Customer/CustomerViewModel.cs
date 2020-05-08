
using DataAccessLayer.Sales;


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
