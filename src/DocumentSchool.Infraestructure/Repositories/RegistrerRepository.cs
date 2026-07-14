using DocumentSchool.Domain.Interfaces;
using DocumentSchool.Entities;
using DocumentSchool.InfraEstructure.Context;
using DocumentSchool.InfraEstructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Repositories
{
    public class RegistrerRepository : IRegistrerRepository
    {
        private readonly DocumentSchoolDbContext repo;

        public RegistrerRepository(DocumentSchoolDbContext _repo)
        {
            repo = _repo;
        }

        public async Task AddRegistrer(int id, Registrer registrer)
        {
            var request = await repo.Docs.Where(x => x.RequestId == id).ToListAsync();
            var regist = new RegistrerModel
            {
                CreatedAt = registrer.CreatedAt,
                DeliveredAt = registrer.DeliveredAt,
                TotalDocuments = request.Count,
                RequestId = registrer.RequestId,
                Amount = registrer.Amount
                
            };
            await repo.Registers.AddAsync(regist);
           await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<Registrer>> GetAllRegisters()
        {
            var reg = await repo.Registers.Include(x => x.Request).AsNoTracking().ToListAsync();

            var nreg = reg.Select(x => new Registrer
            {
                CreatedAt = x.CreatedAt,
                DeliveredAt = x.DeliveredAt,
                TotalDocuments = x.TotalDocuments,
                RequestId = x.RequestId,
                Amount = x.Amount
                
                

            });
            return nreg;
         
         

        }

        public async Task<Registrer> GetRegister(int id)
        {
            var regis = await repo.Registers.FindAsync(id);
            if(regis is null)
            {
                return null;
            }

            var Nreg = new Registrer
            {
                CreatedAt = regis.CreatedAt,
                DeliveredAt = regis.DeliveredAt,
                TotalDocuments = regis.Request.Documents.Count,
                RequestId = regis.RequestId,
                Amount = regis.Amount
            };
            return Nreg;
        }

        public async Task RemoveRegistrer(int id)
        {
            var Dregistrer = await repo.Registers.FindAsync(id);

            repo.Registers.Remove(Dregistrer);
            await repo.SaveChangesAsync();
        }

        public async Task UpdateRegistrer(int id, Registrer registrer)
        {
            var Uregistrer = await repo.Registers.FindAsync(id);
            if(Uregistrer is null)
            {
                return; 
            }

            Uregistrer.CreatedAt = registrer.CreatedAt;
            Uregistrer.DeliveredAt = registrer.DeliveredAt;
            Uregistrer.TotalDocuments = registrer.Request.Documents.Count;
            Uregistrer.RequestId = registrer.RequestId;
            Uregistrer.Amount = registrer.Amount;

            await repo.SaveChangesAsync();
        }
    }
}
