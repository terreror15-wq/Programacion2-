using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DocumentSchool.Aplication.Repository
{
    public interface IRequestRepesitory
    {
        public Task AddRequest(Request request);
        public Task<IEnumerable<Request>> GetAllRequest();
        public Task<Request> GetRequest(int id);
        public Task RemoveRequest(int id);
        public Task UpdateRequest(int id, Request request);


    }
}
