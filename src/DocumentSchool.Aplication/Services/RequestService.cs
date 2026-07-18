using DocumentSchool.Aplication.Contract.Service;
using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Aplication.Repository;
using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Services
{
 
    public class RequestService : IRequestservice
    {
        private readonly IRequestRepesitory service;

        public RequestService(IRequestRepesitory _service)
        {
            service = _service;
        }
            public async Task AddRequest(RequestDTOs request)
        {
            var nrequest = new Request
            {
                CreatedAt = request.CreatedAt,
                Status = request.Status,
                StudentId = request.StudentId
            };
            await service.AddRequest(nrequest);
        }

        public async Task<IEnumerable<RequestDTOs>> GetAllRequest()
        {
            var getallrequest = await service.GetAllRequest();
            var drequest = getallrequest.Select(R => new RequestDTOs
            {
                CreatedAt = R.CreatedAt,
                Status = R.Status,
                StudentId = R.StudentId,
            });
            return drequest;
        }

        public async Task<RequestDTOs> GetRequest(int id)
        {
            var getrequest = await service.GetRequest(id);
            var brequest = new RequestDTOs
            {
                CreatedAt = getrequest.CreatedAt,
                Status = getrequest.Status,
                StudentId = getrequest.StudentId,
            };
            return brequest;
        }

        public async Task RemoveRequest(int id)
        {
            await service.RemoveRequest(id);
        }

        public async Task UpdateRequest(int id, RequestDTOs request)
        {
            var urequest = new Request
            {
                CreatedAt = request.CreatedAt,
                Status = request.Status,
                StudentId = request.StudentId
            };
            await service.UpdateRequest(id, urequest);
        }
    }
}
