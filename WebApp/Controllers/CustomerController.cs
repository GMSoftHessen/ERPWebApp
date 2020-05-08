
using BusinessLayer.Base;
using DataAccessLayer.Sales;
using System;
using System.Web.Http;

namespace WebApp.Controllers
{
    [RoutePrefix("api")]
    public class CustomerController : ApiController
    {
        ICustomerViewModel _ICustomerViewModel;
        public CustomerController(ICustomerViewModel customerViewModel)
        {
            _ICustomerViewModel = customerViewModel;
        }

        [Route("AllCustomers")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = _ICustomerViewModel.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route(" Customer/{ customerId}")]
        [HttpGet]
        public IHttpActionResult GetCustomer(int customerId)
        {
            try
            {
                var result = _ICustomerViewModel.Find(customerId);
                if (result == null)
                    return NotFound();

                return Ok(result);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [Route("Customer")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]  Customer customer)
        {
            try
            {
                int id = 0;
                if (ModelState.IsValid)
                {
                    id = _ICustomerViewModel.Insert(customer);
                    return Ok("Yes :" + id);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return BadRequest();
        }

        [Route("Customer/{id}")]
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]  Customer customer)
        {
            try
            {
                if (id != customer?.Id)
                    return BadRequest();

                if (ModelState.IsValid)
                {
                    _ICustomerViewModel.Update(customer);
                    //return Ok("Yes :" + id);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return BadRequest();
        }

        [Route(" Customer/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();
                _ICustomerViewModel.Delete(id);

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
