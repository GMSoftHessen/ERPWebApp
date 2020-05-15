
using BusinessLayer.BO;
using BusinessLayer.Base;


namespace BusinessLayer.Customize
{
    public partial class UserBO : UserBaseBO, IUserBO
    {
        public UserBO(IUserRepository userRepository) : base(userRepository)
        {

        }


    }
}