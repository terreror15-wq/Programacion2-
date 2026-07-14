using DocumentSchool.Domain;
using DocumentSchool.Domain.DTOs;
using DocumentSchool.Domain.Interfaces;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStundentRepository repo;

        public StudentController(IStundentRepository _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>>GetAll()
        {
            var AllStudent = await repo.GetAllStudent();


            return Ok(AllStudent);
        }
        [HttpPost]

        public async Task<ActionResult> CreateStudent(StudentDTOs student)
        {
            var student1 = new Student
            {
                Name = student.Name,
                LastNAme = student.LastNAme,
                Grade = student.Grade,
                Age = student.Age,
                Tel = student.Tel
            };
            await repo.AddStudent(student1);

            return NoContent();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<StudentDTOs>> GetByid(int id)
        {
            var Student = await repo.GetStudent(id);

            var studentdto = new StudentDTOs
            {
                Name = Student.Name,
                LastNAme = Student.LastNAme,
                Age = Student.Age,
                Grade = Student.Grade,
                Tel = Student.Tel

            };
            return studentdto;

            
        }
        [HttpPut]

        public async Task<ActionResult> UpdateStudent(StudentDTOs student, int id)
        {

            var student2 = new Student
            {
                Name = student.Name,
                LastNAme = student.LastNAme,
                Age = student.Age,
                Grade = student.Grade,
                Tel = student.Tel
            };
            
            await repo.UpdateStudent(id, student2);
            return NoContent();



        }
        [HttpDelete("{id}")]

        public async Task<ActionResult>RemuveStudent(int id)
        {
            await repo.RemoveStudent(id);
            return NoContent();

        }
        
    }
}
