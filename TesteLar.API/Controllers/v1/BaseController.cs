using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TesteLar.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected ActionResult CustomResponse(object result, int statusCode = StatusCodes.Status200OK)
        {
            if (result == null)
            {
                return NotFound();
            }

            return StatusCode(statusCode, result);
        }
    }
}
