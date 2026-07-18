
using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using DocumentSchool.Aplication.Contract.Service;

namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrerController : ControllerBase
    {
        private readonly IRegistrerService service;

        public RegistrerController(IRegistrerService _service)
        {
            service = _service;

        }              

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistrerDTOs>>> GetAllRegistrer()
        {
            var gettingall =  await service.GetAllRegisters();
            return Ok(gettingall);
           
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistrerDTOs>>GetRegistrerById(int id)
        {
            var getregistrer = await service.GetRegister(id);
            return Ok(getregistrer);

        }
        [HttpPost("{id}")]
        public async Task<ActionResult>AddRegistrer(int id, RegistrerDTOs registrer)
        {
            await service.AddRegistrer(id,registrer);
            return NoContent();
            
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateRegistrer(int id, RegistrerDTOs registrerDT)
        {
            await service.UpdateRegistrer(id, registrerDT);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteRegistrer(int id)
        {
            await service.RemoveRegistrer(id);
            return NoContent();
        }

       
    }
}
