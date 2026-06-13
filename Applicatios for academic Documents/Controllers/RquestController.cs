
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea_1.Models;
using Tarea_1.Data;
using Tarea_1.DTOs;

namespace Tarea_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<RequestDTOs>> GetRequests()
        {
            var requests = DatesDefault.requests.AsReadOnly();
            return Ok(requests.Select(x => new RequestDTOs
            {
                CreateDate = x.CreateDate,
                DeliveredTime = x.DeliveredTime,
                RequestStatus = x.RequestStatus
            }));
        }

        [HttpPost]
        public ActionResult AddRequest(RequestDTOs request)
        {
            if (request is null)
            {
                return NotFound();
            }
            request.Id = DatesDefault.contador++;
            var newRequest = new Request
            {
                Id = request.Id,
                CreateDate = request.CreateDate,
                DeliveredTime = request.DeliveredTime,
                RequestStatus = request.RequestStatus
            };
            DatesDefault.requests.Add(newRequest);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRequest(int id)
        {
            var requestFound = DatesDefault.requests.Find(x => x.Id == id);

            if (requestFound is null)
            {
                return NotFound();
            }
            DatesDefault.requests.Remove(requestFound);
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult GetRequest(int id)
        {
            var oneRequest = DatesDefault.requests.Find(x => x.Id == id);
            if (oneRequest is null)
            {
                Console.WriteLine("Request not found");
                return NotFound();
            }
            return Ok(oneRequest);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateRequest(int id, RequestDTOs newRequest)
        {
            var existingRequest = DatesDefault.requests.Find(x => x.Id == id);
            if (existingRequest is null)
            {
                return NotFound();
            }

            existingRequest.CreateDate = newRequest.CreateDate == default ? existingRequest.CreateDate : newRequest.CreateDate;
            existingRequest.DeliveredTime = newRequest.DeliveredTime == default ? existingRequest.DeliveredTime : newRequest.DeliveredTime;
            existingRequest.RequestStatus = newRequest.RequestStatus == null ? existingRequest.RequestStatus : newRequest.RequestStatus;

            return Ok(newRequest);
        }
    }
}
