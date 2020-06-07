
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class ProductBaseViewModel:IProductViewModel
    {
        #region private members
        private ProductBaseBO _ProductBaseBO;
        #endregion private members

        #region abfragen
        public ProductBaseViewModel(ProductBaseBO ProductBO)
        {
            _ProductBaseBO = ProductBO;
        }

        public List<Product> GetAll()
        {
            return _ProductBaseBO.GetAll();
        }
        public Product Find(int id)
        {
            return _ProductBaseBO.Find(id);
        }

        public int Insert(Product Product)
        {
            return _ProductBaseBO.Insert(Product);
        }

        public void Update(Product Product)
        {
            _ProductBaseBO.Update(Product);
        }

        public void Delete(int id)
        {
            _ProductBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
