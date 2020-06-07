

namespace BusinessLayer.Customize
{
    public class PermissionsBO
    {
        PermissionsRepository _PermissionsRepository;
        
        public PermissionsBO(PermissionsRepository PermissionsRepository) 
        {
            _PermissionsRepository = PermissionsRepository;
        }
    }
}