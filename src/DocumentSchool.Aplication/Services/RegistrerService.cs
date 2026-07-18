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
    public class RegistrerService : IRegistrerService
    {
        private readonly IRegistrerRepository service;

        public RegistrerService(IRegistrerRepository _service)
        {
            service = _service;
        }
        public async Task AddRegistrer(int id, RegistrerDTOs registrer)
        {
            var nregistrer = new Registrer
            {
                Amount = registrer.Amount,
                DeliveredAt = registrer.DeliveredAt,
                TotalDocuments = registrer.TotalDocuments,
                RequestId = registrer.RequestId

            };
            await service.AddRegistrer(id, nregistrer);
            
        }

        public async Task<IEnumerable<RegistrerDTOs>> GetAllRegisters()
        {
            var allregistrer = await service.GetAllRegisters();

            var nregistrer = allregistrer.Select(D => new RegistrerDTOs
            {
                CreatedAt = D.CreatedAt,
                DeliveredAt = D.DeliveredAt,
                TotalDocuments = D.TotalDocuments,
                RequestId = D.RequestId,
                Amount = D.Amount
            });
            return nregistrer;
        }

        public async Task<RegistrerDTOs> GetRegister(int id)
        {
            var getregistrer = await service.GetRegister(id);
            var cregistrer = new RegistrerDTOs
            {
                CreatedAt = getregistrer.CreatedAt,
                DeliveredAt = getregistrer.DeliveredAt,
                TotalDocuments = getregistrer.TotalDocuments,
                RequestId = getregistrer.RequestId,
                Amount = getregistrer.Amount
            };
            return cregistrer;
        }

        public async Task RemoveRegistrer(int id)
        {
            await service.RemoveRegistrer(id);
        }

        public async Task UpdateRegistrer(int id, RegistrerDTOs registrer)
        {
            var uregistrer = new Registrer
            {
                CreatedAt = registrer.CreatedAt,
                DeliveredAt = registrer.DeliveredAt,
                TotalDocuments = registrer.TotalDocuments,
                RequestId = registrer.RequestId,
                Amount = registrer.Amount
            };
            await service.UpdateRegistrer(id,uregistrer);
        }
    }
}
