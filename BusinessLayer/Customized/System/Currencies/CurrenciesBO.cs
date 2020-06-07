

namespace BusinessLayer.Customize
{
    public class CurrenciesBO
    {
        CurrenciesRepository _CurrenciesRepository;
        
        public CurrenciesBO(CurrenciesRepository CurrenciesRepository) 
        {
            _CurrenciesRepository = CurrenciesRepository;
        }
    }
}