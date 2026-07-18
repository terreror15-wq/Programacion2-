using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Contract.Service
{
    public interface IStudentService
    {
        public Task<StudentDTOs> GetStudent(int id);
        public Task<IEnumerable<StudentDTOs>> GetAllStudent();
        public Task AddStudent(StudentDTOs student);
        public Task UpdateStudent(int id, StudentDTOs student);
        public Task RemoveStudent(int id);
    }
}
