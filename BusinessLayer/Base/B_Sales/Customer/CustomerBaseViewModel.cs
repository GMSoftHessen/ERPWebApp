
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class CustomerBaseViewModel
    {
        #region private members
        private CustomerBaseBO _customerBaseBO;
        #endregion private members

        #region abfragen
        public CustomerBaseViewModel(CustomerBaseBO customerBO)
        {
            _customerBaseBO = customerBO;
        }

        public List<Customer> GetAll()
        {
            return _customerBaseBO.GetAll();
        }
        public Customer Find(int id)
        {
            return _customerBaseBO.Find(id);
        }

        public int Insert(Customer customer)
        {
            return _customerBaseBO.Insert(customer);
        }

        public void Update(Customer customer)
        {
            _customerBaseBO.Update(customer);
        }

        public void Delete(int id)
        {
            _customerBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
