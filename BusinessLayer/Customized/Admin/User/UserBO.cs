

namespace BusinessLayer.Customize
{
    public class UserBO
    {
        UserRepository _UserRepository;
        
        public UserBO(UserRepository UserRepository) 
        {
            _UserRepository = UserRepository;
        }
    }
}