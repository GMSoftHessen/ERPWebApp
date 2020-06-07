
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class CurrenciesBaseViewModel
    {
        #region private members
        private CurrenciesBaseBO _CurrenciesBaseBO;
        #endregion private members

        #region abfragen
        public CurrenciesBaseViewModel(CurrenciesBaseBO CurrenciesBO)
        {
            _CurrenciesBaseBO = CurrenciesBO;
        }

        public List<Currencies> GetAll()
        {
            return _CurrenciesBaseBO.GetAll();
        }
        public Currencies Find(int id)
        {
            return _CurrenciesBaseBO.Find(id);
        }

        public int Insert(Currencies Currencies)
        {
            return _CurrenciesBaseBO.Insert(Currencies);
        }

        public void Update(Currencies Currencies)
        {
            _CurrenciesBaseBO.Update(Currencies);
        }

        public void Delete(int id)
        {
            _CurrenciesBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
