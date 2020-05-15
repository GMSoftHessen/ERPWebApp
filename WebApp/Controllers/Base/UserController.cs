
using BusinessLayer;
using DataAccessLayer.Admin;
using System;
using System.Web.Http;

namespace WebApp.Controllers
{
    [RoutePrefix("api")]
    public class UserController : ApiController
    {
        IUserViewModel _IUserViewModel;
        public UserController(IUserViewModel userViewModel)
        {
            _IUserViewModel = userViewModel;
        }

        [Route("Users")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = _IUserViewModel.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route(" User/{userId}")]
        [HttpGet]
        public IHttpActionResult GetUser(int userId)
        {
            try
            {
                var result = _IUserViewModel.Find(userId);
                if (result == null)
                    return NotFound();

                return Ok(result);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [Route("User")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]  User user)
        {
            try
            {
                int id = 0;
                if (ModelState.IsValid)
                {
                    id = _IUserViewModel.Insert(user);
                    return Ok("Yes :" + id);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return BadRequest();
        }

        [Route("User/{id}")]
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]  User user)
        {
            try
            {
                if (id != user?.Id)
                    return BadRequest();

                if (ModelState.IsValid)
                {
                    _IUserViewModel.Update(user);
                    //return Ok("Yes :" + id);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return BadRequest();
        }

        [Route("User/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();
                _IUserViewModel.Delete(id);

                //_ICustomerViewModel.Update(customer);
                //return Ok("Yes :" + id);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return BadRequest();
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
