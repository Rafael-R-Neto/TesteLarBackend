using Microsoft.AspNetCore.Mvc;
using System;
using TesteLar.Application.DTO;
using TesteLar.Application.Interfaces;
using TesteLar.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteLar.API.Controllers.v1
{
    [ApiExplorerSettings(GroupName = "v1", IgnoreApi = false)]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : BaseController
    {

        protected readonly IPersonApplicationService _personApplicationService;

        public PersonController(IPersonApplicationService personApplicationService)
        {
            _personApplicationService = personApplicationService;
        }

        [HttpGet]
        public async Task<ActionResult<PersonDTO>> Get()
        {
            return CustomResponse(await _personApplicationService.GetAllPeopleAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDTO>> Get(int id)
        {
            return CustomResponse(await _personApplicationService.GetPersonByIdAsync(id));
        }
        
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonDTO person)
        {
            try
            {
                if(await _personApplicationService.AddPersonAsync(person))
                    return CustomResponse("Salvo com sucesso!", 200);

                return CustomResponse("Erro ao salvar!", 400);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] PersonDTO person)
        {
            try
            {
                if (await _personApplicationService.UpdatePersonAsync(person))
                    return CustomResponse("Salvo com sucesso!", 200);

                return CustomResponse("Erro ao salvar!", 400);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (await _personApplicationService.DeletePersonAsync(id))
                    return CustomResponse("Removido com sucesso!", 200);

                return CustomResponse("Erro ao remover!", 400);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
