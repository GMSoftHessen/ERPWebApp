
using BusinessLayer.Base;
using DataAccessLayer.Sales;

namespace BusinessLayer.Customize
{
    public partial class UserViewModel : UserBaseViewModel, IUserViewModel
    {
        IUserBO _IUserBO;
        public UserViewModel(IUserBO userBO) : base(userBO)
        {
            _IUserBO = userBO;
        }

    }

}
