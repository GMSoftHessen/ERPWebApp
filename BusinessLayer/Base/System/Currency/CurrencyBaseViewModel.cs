
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class CurrencyBaseViewModel:ICurrencyViewModel
    {
        #region private members
        private CurrencyBaseBO _CurrencyBaseBO;
        #endregion private members

        #region abfragen
        public CurrencyBaseViewModel(CurrencyBaseBO CurrencyBO)
        {
            _CurrencyBaseBO = CurrencyBO;
        }

        public List<Currency> GetAll()
        {
            return _CurrencyBaseBO.GetAll();
        }
        public Currency Find(int id)
        {
            return _CurrencyBaseBO.Find(id);
        }

        public int Insert(Currency Currency)
        {
            return _CurrencyBaseBO.Insert(Currency);
        }

        public void Update(Currency Currency)
        {
            _CurrencyBaseBO.Update(Currency);
        }

        public void Delete(int id)
        {
            _CurrencyBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
