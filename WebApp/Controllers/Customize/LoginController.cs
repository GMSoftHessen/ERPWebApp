
using BusinessLayer;
using DataAccessLayer.Admin;
using DataAccessLayer.DTOs;
using System;
using System.Web.Http;

namespace WebApp.Controllers
{
    [RoutePrefix("api")]
    public class LoginController : ApiController
    {
        IUserViewModel _IUserViewModel;
        public LoginController(IUserViewModel userViewModel)
        {
            _IUserViewModel = userViewModel;
        }

        [Route("Login")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]  UserDTO user)
        {
            try
            {
                if (user == null)
                    return BadRequest();

                //bool isValid = EasyEncryption.MD5.IsValidMD5(user.Password);
                string[] login = new string[2] { "success:false", "msg: Incorrect user or password.!" };
                //if (isValid == false)
                //{
                //    return BadRequest();
                //}
                //else
                //{
                //    User result = _IUserViewModel.GetUser(user.UserName);
                //    if (result != null)
                //    {
                //        bool success = EasyEncryption.MD5.Equals(user.Password, result.Password);
                //        if (success)
                            login = new string[2] { "{" + "success:true", "msg: User authenticated!" + "}"};
                       return Ok();
                //    }
                //    else
                //    {
                //        return BadRequest();
                //    }

                //}
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [Route("Logout")]
        [HttpPost]
        public IHttpActionResult Logout([FromBody]  UserDTO user)
        {
            try
            {
                if (user == null)
                    return BadRequest();

                string[] logout = new string[2] { "success:true", "msg: logout" };
                return Ok(logout);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


    }
}
