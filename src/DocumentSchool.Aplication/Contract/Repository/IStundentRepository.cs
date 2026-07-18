using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Repository
{
    public interface IStundentRepository
    {
        public Task<Student>GetStudent(int id);
        public Task<IEnumerable<Student>>GetAllStudent();
        public Task AddStudent(Student student);
        public Task UpdateStudent(int id, Student student);
        public Task RemoveStudent(int id);
    }
}
