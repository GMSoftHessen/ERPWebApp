
using BusinessLayer.Base;

namespace BusinessLayer.Customize
{
    public partial class UserRepository : UserBaseRepository, IUserRepository
    {
        #region ctr
        public UserRepository() : base(500)

        {

        }
        #endregion ctr
    }
}