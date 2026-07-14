using DocumentSchool.Domain.Interfaces;
using DocumentSchool.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestRepesitory repo;

        public RequestController(IRequestRepesitory _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestDTOs>>>GetAllRequest()
        {
            var Getall = await repo.GetAllRequest();

            return Ok(Getall);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestDTOs>>GetRequestById(int id)
        {
            var Getrequest = await repo.GetRequest(id);

            var Nrequest = new RequestDTOs
            {
                CreatedAt = Getrequest.CreatedAt,
                Status = Getrequest.Status,
                StudentId = Getrequest.StudentId
            };
            return Ok(Nrequest);
        }
        [HttpPost]
        public async Task<ActionResult>AddRequest(RequestDTOs request)
        {
           

             var nrequest = new Request
             {
                 CreatedAt = request.CreatedAt,
                 Status = request.Status,
                 StudentId = request.StudentId

             };
              await repo.AddRequest(nrequest);
            return NoContent();


        }
        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteRequest(int id)
        {
            await repo.RemoveRequest(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateRequest(int id, RequestDTOs request)
        {
            var newrequest = new Request
            {
                CreatedAt = request.CreatedAt,
                Status = request.Status,
                StudentId = request.StudentId
            };
            await repo.UpdateRequest(id, newrequest);
            return NoContent();
            
        }


    }
}
