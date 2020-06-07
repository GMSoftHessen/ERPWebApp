
using DataAccessLayer.System;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface ICurrencyViewModel
    {
        List<Currency> GetAll();
        Currency Find(int id);
        void Update(Currency currency);
        int Insert(Currency currency);
        void Delete(int id);
     
    }
}