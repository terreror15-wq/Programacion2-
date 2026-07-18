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
    public class StudentService : IStudentService
    {
        private readonly IStundentRepository service; 

        public StudentService(IStundentRepository _service)
        {
            service = _service;
        }
        public async Task AddStudent(StudentDTOs student)
        {
            var nstudent = new Student
            {
                Name = student.Name,
                LastNAme = student.LastNAme,
                Age = student.Age,
                Grade = student.Grade,
                Tel = student.Tel,
            };
            await service.AddStudent(nstudent);
        }

        public async Task<IEnumerable<StudentDTOs>> GetAllStudent()
        {
            var getall = await service.GetAllStudent();

            var nstuden = getall.Select(x => new StudentDTOs
            {
                Name = x.Name,
                LastNAme = x.LastNAme,
                Age = x.Age,
                Grade = x.Grade,
                Tel = x.Tel

            });
            return nstuden;
            
        }

        public async Task<StudentDTOs> GetStudent(int id)
        {
            var student = await service.GetStudent(id);
            var Nstudent = new StudentDTOs
            {
                Name = student.Name,
                LastNAme = student.LastNAme,
                Age = student.Age,
                Grade = student.Grade,
                Tel = student.Tel
            };
            return Nstudent;
            
        }

        public async Task RemoveStudent(int id)
        {
            await service.RemoveStudent(id);
        }

        public async Task UpdateStudent(int id, StudentDTOs student)
        {
            var upstudent = new Student
            {
                Name = student.Name,
                LastNAme = student.LastNAme,
                Age = student.Age,
                Grade = student.Grade,
                Tel = student.Grade
            };
            await service.UpdateStudent(id, upstudent);
        }
    }
}
