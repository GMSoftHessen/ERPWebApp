using DataAccessLayer.edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public partial interface ICustomerViewModel
    {
        List<Customer> GetAll();
        Customer Find(int id);
        void Delete(int id);
        void Update(Customer customer);
        int Insert(Customer customer);
        string GetNextCustomerNumber();
    }
}
