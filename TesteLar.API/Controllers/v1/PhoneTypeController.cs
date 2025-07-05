using Microsoft.AspNetCore.Mvc;
using TesteLar.Application.DTO;
using TesteLar.Application.Interfaces;

namespace TesteLar.API.Controllers.v1
{
    [ApiExplorerSettings(GroupName = "v1", IgnoreApi = false)]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PhoneTypeController : BaseController
    {
        protected readonly IPhoneTypeApplicationService _phoneTypeApplicationService;
        public PhoneTypeController(IPhoneTypeApplicationService phoneTypeApplicationService)
        {
            _phoneTypeApplicationService = phoneTypeApplicationService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<PhoneTypeDTO>>> GetAll()
        {
            return CustomResponse(await _phoneTypeApplicationService.GetAllPhoneTypesAsync());
        }
    }
}
