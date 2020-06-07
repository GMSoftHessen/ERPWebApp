
using BusinessLayer;
using DataAccessLayer.Admin;
using System;
using System.Security.Claims;
using System.Web.Http;
using Thinktecture.IdentityModel.WebApi;

namespace WebApp.Controllers
{
    [RoutePrefix("api")]
    [ScopeAuthorize("read")]
    public class UserController : ApiController
    {
        IUserViewModel _IUserViewModel;
        public UserController()
        {
           // _IUserViewModel = userViewModel;
        }

        

        [Route("User")]
        [HttpGet]
        public IHttpActionResult GetUser()
        {
            try
            {

                var claimsPrincipal = User as ClaimsPrincipal;

                var username = claimsPrincipal?.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;

                var result = username;//_IUserViewModel.Find(userId);
                if (result == null)
                    return NotFound();

                return Ok(result);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        

       

        // GET
        // POST
        // PUT
        // PATCH
        // DELETE

        // 201 Created
        // 304 Not Modified
        // 404 Not Found
        // 401 Unauthorized
        // 403 Forbidden  
    }
}
