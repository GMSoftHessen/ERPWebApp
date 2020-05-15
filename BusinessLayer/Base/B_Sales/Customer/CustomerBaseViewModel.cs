
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public abstract class CustomerBaseViewModel
    {
        #region abfragen
        public CustomerBaseViewModel(ICustomerBO customerBO)
        {
            _customerBO = customerBO;
        }

        public List<Customer> GetAll()
        {
            return _customerBO.GetAll();
        }
        public Customer Find(int id)
        {
            return _customerBO.Find(id);
        }

        public int Insert(Customer customer)
        {
            return _customerBO.Insert(customer);
        }

        public void Update(Customer customer)
        {
            _customerBO.Update(customer);
        }

        public void Delete(int id)
        {
            _customerBO.Delete(id);
        }
        #endregion abfragen

        #region private members
        private ICustomerBO _customerBO;
        #endregion private members
    }
}
