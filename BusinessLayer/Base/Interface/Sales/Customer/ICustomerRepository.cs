
using DataAccessLayer.Sales;
using System.Collections.Generic;

public partial interface ICustomerRepository
{
    SalesDbContext DbContext { get; set; }
    List<Customer> All();
    Customer Find(int id);
    void Delete(int id);
    void Update(Customer customer);
    void Insert(Customer customer);
}