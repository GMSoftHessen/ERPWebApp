

namespace BusinessLayer.Customize
{
    public class MenuBO
    {
        MenuRepository _MenuRepository;
        
        public MenuBO(MenuRepository MenuRepository) 
        {
            _MenuRepository = MenuRepository;
        }
    }
}