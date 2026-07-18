using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Contract.Service
{
    public interface IRequestservice
    {
        public Task AddRequest(RequestDTOs request);
        public Task<IEnumerable<RequestDTOs>> GetAllRequest();
        public Task<RequestDTOs> GetRequest(int id);
        public Task RemoveRequest(int id);
        public Task UpdateRequest(int id, RequestDTOs request);
    }
}
