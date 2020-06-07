
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
        private CustomerBaseBO _CustomerBaseBO;
        #endregion private members

        #region abfragen
        public CustomerBaseViewModel(CustomerBaseBO CustomerBO)
        {
            _CustomerBaseBO = CustomerBO;
        }

        public List<Customer> GetAll()
        {
            return _CustomerBaseBO.GetAll();
        }
        public Customer Find(int id)
        {
            return _CustomerBaseBO.Find(id);
        }

        public int Insert(Customer Customer)
        {
            return _CustomerBaseBO.Insert(Customer);
        }

        public void Update(Customer Customer)
        {
            _CustomerBaseBO.Update(Customer);
        }

        public void Delete(int id)
        {
            _CustomerBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
