using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApp.Controllers.Customize
{
    public class AsyncTestController : ApiController
    {

        [Route("Orders")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            try
            {
                var result = await GetAllOrders();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        private async Task<IHttpActionResult> GetAllOrders()
        {
            return Ok();
        }
    }
}
