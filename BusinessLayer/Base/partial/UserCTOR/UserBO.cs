
using BusinessLayer.BO;
using BusinessLayer.Base;
using DataAccessLayer.Admin;

namespace BusinessLayer.Customize
{
    public partial class UserBO : UserBaseBO, IUserBO
    {
        public UserBO(IUserRepository userRepository) : base(userRepository)
        {

        }

        public User GetUser(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}