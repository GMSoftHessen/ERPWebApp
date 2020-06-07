
using DataAccessLayer.Sales;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface ICustomerViewModel
    {
        List<Customer> GetAll();
        Customer Find(int id);
        void Update(Customer customer);
        int Insert(Customer customer);
        void Delete(int id);
     
    }
}