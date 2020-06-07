

namespace BusinessLayer.Customize
{
    public class GroupBO
    {
        GroupRepository _GroupRepository;
        
        public GroupBO(GroupRepository GroupRepository) 
        {
            _GroupRepository = GroupRepository;
        }
    }
}