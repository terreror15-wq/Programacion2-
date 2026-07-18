using DocumentSchool.Domain;
using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DocumentSchool.Aplication.Contract.Service;

namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;

        public StudentController(IStudentService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTOs>>>GetAll()
        {
            var AllStudent = await service.GetAllStudent();
            return Ok(AllStudent);


            
        }
        [HttpPost]

        public async Task<ActionResult> CreateStudent(StudentDTOs student)
        {
            await service.AddStudent(student);
            return NoContent();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<StudentDTOs>> GetByid(int id)
        {
            var student = await service.GetStudent(id);
            return Ok(student);
            

            
        }
        [HttpPut]

        public async Task<ActionResult> UpdateStudent(StudentDTOs student, int id)
        {

            await service.UpdateStudent(id, student);
            return NoContent();


        }
        [HttpDelete("{id}")]

        public async Task<ActionResult>RemuveStudent(int id)
        {
            await service.RemoveStudent(id);
            return NoContent();
        }
        
    }
}
