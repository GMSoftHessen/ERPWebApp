
using DataAccessLayer.Sales;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface IProductViewModel
    {
        List<Product> GetAll();
        Product Find(int id);
        void Update(Product product);
        int Insert(Product product);
        void Delete(int id);
     
    }
}