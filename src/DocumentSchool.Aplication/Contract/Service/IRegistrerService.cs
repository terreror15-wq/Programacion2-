using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Contract.Service
{
    public interface IRegistrerService
    {
        public Task<RegistrerDTOs> GetRegister(int id);
        public Task<IEnumerable<RegistrerDTOs>> GetAllRegisters();
        public Task AddRegistrer(int id, RegistrerDTOs registrer);
        public Task RemoveRegistrer(int id);
        public Task UpdateRegistrer(int id, RegistrerDTOs registrer);
    }
}
