
using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Runtime.CompilerServices;
using DocumentSchool.Aplication.Contract.Service;

namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestservice service;

        public RequestController(IRequestservice _service)
        {
            service = _service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestDTOs>>>GetAllRequest()
        {
            var Getall = await service.GetAllRequest();

            return Ok(Getall);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestDTOs>>GetRequestById(int id)
        {
            var Getrequest = await service.GetRequest(id);         
            return Ok(Getrequest);
        }
        [HttpPost]
        public async Task<ActionResult>AddRequest( RequestDTOs request)
        {
            await service.AddRequest(request);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult>DeleteRequest(int id)
        {
            await service.RemoveRequest(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateRequest(int id, RequestDTOs request)
        {
            await service.UpdateRequest(id, request);
            return NoContent();
            
        }


    }
}
