using DocumentSchool.Domain.Interfaces;
using DocumentSchool.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrerController : ControllerBase
    {
        private readonly IRegistrerRepository repo;

        public RegistrerController(IRegistrerRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistrerDTOs>>> GetAllRegistrer()
        {
            var gettingall = await repo.GetAllRegisters();
            return Ok(gettingall.Select(x => new RegistrerDTOs
            {
                CreatedAt = x.CreatedAt,
                DeliveredAt = x.DeliveredAt,
                TotalDocuments = x.TotalDocuments,
                RequestId = x.RequestId,
                Amount = x.Amount

            }));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistrerDTOs>>GetRegistrerById(int id)
        {
            var getregistrer = await repo.GetRegister(id);

            var nregistrer = new RegistrerDTOs
            {
                CreatedAt = getregistrer.CreatedAt,
                DeliveredAt = getregistrer.DeliveredAt,
                TotalDocuments = getregistrer.TotalDocuments,
                RequestId = getregistrer.RequestId,
                Amount = getregistrer.Amount
                


            };
            return nregistrer;

        }
        [HttpPost("{id}")]
        public async Task<ActionResult>AddRegistrer(int id, CreateRegistrerDTOs registrer)
        {
            var addregistrer = new Registrer
            {
                CreatedAt = registrer.CreatedAt,
                DeliveredAt = registrer.DeliveredAt,
                
                RequestId = registrer.RequestId,
                Amount = registrer.Amount
            };
            await repo.AddRegistrer(id,addregistrer);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateRegistrer(int id, CreateRegistrerDTOs registrerDT)
        {
            var updateregistrer = new Registrer
            {
                CreatedAt = registrerDT.CreatedAt,
                DeliveredAt = registrerDT.DeliveredAt,
               
                RequestId = registrerDT.RequestId,
                Amount = registrerDT.Amount
            };
            await repo.UpdateRegistrer(id,updateregistrer);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteRegistrer(int id)
        {
            await repo.RemoveRegistrer(id);
            return NoContent();
        }

       
    }
}
