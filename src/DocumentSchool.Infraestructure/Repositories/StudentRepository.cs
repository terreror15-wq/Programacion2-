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
    public class StudentRepository : IStundentRepository
    {

        private readonly DocumentSchoolDbContext repo;

        public StudentRepository(DocumentSchoolDbContext _repo) 
        {
            repo = _repo;
        }
        public async Task AddStudent(Student student)
        {
            var NStudent = new StudentModel
            {
                Id = student.Id,
                Name = student.Name,
                LastNAme = student.LastNAme,
                Tel =  student.Tel,
                Grade = student.Grade


            };

            await repo.Student.AddAsync(NStudent);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            var Students = await repo.Student.AsNoTracking().ToListAsync();
            var Nstude = Students.Select(x => new Student
            {
                Id = x.Id,
                Name = x.Name,
                LastNAme = x.LastNAme,
                Grade = x.Grade,
                Age = x.Age,
                Tel = x.Tel
            });
            return Nstude;
        }

        public async Task<Student> GetStudent(int id)
        {
            var Stu = await repo.Student.FindAsync(id);
            if(Stu is null) 
            {
                return null;
            }
            var DStudent = new Student
            {
                Id = Stu.Id,
                Name = Stu.Name,
                LastNAme = Stu.LastNAme,
                Grade = Stu.Grade,
                Age = Stu.Age,
                Tel = Stu.Tel

            };
            return DStudent;
        }

        public async Task RemoveStudent(int id)
        {
            var Studen = await repo.Student.FindAsync(id);

            repo.Student.Remove(Studen);

            await repo.SaveChangesAsync();
        }

        public async Task UpdateStudent(int id, Student student)
        {
            var student1 = await repo.Student.FindAsync(id);
            if(student1 is null)
            {
                return;
            }
            student1.Name = student.Name;
            student1.LastNAme = student.LastNAme;
            student1.Age = student.Age;
            student1.Tel = student.Tel;
            student1.Grade = student.Grade;
            await repo.SaveChangesAsync();
        }
    }
}
