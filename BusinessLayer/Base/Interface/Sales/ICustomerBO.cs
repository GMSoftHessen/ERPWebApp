using DataAccessLayer.edmx;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface ICustomerBO
    {
        List<Customer> GetAll();
        Customer Find(int id);
        void Update(Customer customer);
        int Insert(Customer customer);
        void Delete(int id);
    }
}