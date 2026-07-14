using DocumentSchool.Domain.Interfaces;
using DocumentSchool.Entities;
using DocumentSchool.InfraEstructure.Context;
using DocumentSchool.InfraEstructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Repositories
{
    public class RequestRepository : IRequestRepesitory
    {

        private readonly DocumentSchoolDbContext repo;

        public RequestRepository(DocumentSchoolDbContext _repo)
        {
            repo = _repo;
        }
        public async Task AddRequest(Request request)
        {
            var reques = new RequestModel
            {
                CreatedAt = request.CreatedAt,
                StudentId = request.StudentId,
                Status = request.Status
               
            };
           await repo.Request.AddAsync(reques);
           await repo.SaveChangesAsync();

            
        }

        public async Task<IEnumerable<Request>> GetAllRequest()
        {
            var requests = await repo.Request.AsNoTracking().ToListAsync();
            var nrequests = requests.Select(x => new Request
            {
                CreatedAt = x.CreatedAt,
                StudentId = x.StudentId,
                Status = x.Status
            });
            return nrequests;

            
            
        }

        public async Task<Request> GetRequest(int id)
        {
            var request = await repo.Request.Where(x => x.Id == id).Include(p => p.Student).FirstOrDefaultAsync();
            if(request is null)
            {
                return null; 
            }

            var student = new Student
            {
                Name = request.Student.Name,
                LastNAme = request.Student.LastNAme,
                Age = request.Student.Age,
                Tel = request.Student.Tel,
                Grade = request.Student.Grade
            };
            var req = new Request
            {
                CreatedAt = request.CreatedAt,
                Status = request.Status,
                StudentId = request.StudentId,
                Student = student
                
            };
            return req;
          
        }

        public async Task RemoveRequest(int id)
        {
            var request = await repo.Request.FindAsync(id);
            if(request is null)
            {
                return;
            }
            repo.Request.Remove(request);
            await repo.SaveChangesAsync();


        }

        public async Task UpdateRequest(int id, Request request)
        {
            var reques = await repo.Request.FindAsync(id);
            if(reques is null)
            {
                return;
            }
            reques.CreatedAt = request.CreatedAt;
            reques.Status = request.Status;

            await repo.SaveChangesAsync();

        }
    }
}
