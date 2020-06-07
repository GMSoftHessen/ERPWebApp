

namespace BusinessLayer.Customize
{
    public class CurrencyBO
    {
        CurrencyRepository _CurrencyRepository;
        
        public CurrencyBO(CurrencyRepository CurrencyRepository) 
        {
            _CurrencyRepository = CurrencyRepository;
        }
    }
}