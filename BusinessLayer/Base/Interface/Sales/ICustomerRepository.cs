using DataAccessLayer.edmx;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface ICustomerRepository
    {
        ChinookDbContext DbContext { get; set; }
        List<Customer> All();
        Customer Find(int id);
        void Delete(int id);
        void Update(Customer customer);
        void Insert(Customer customer);



    }
}