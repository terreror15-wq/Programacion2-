using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Repository
{
    public interface IRegistrerRepository
    {
        public Task<Registrer> GetRegister(int id);
        public Task<IEnumerable<Registrer>> GetAllRegisters();
        public Task AddRegistrer(int id, Registrer registrer);
        public Task RemoveRegistrer(int id);
        public Task UpdateRegistrer(int id, Registrer registrer);
    }
}
