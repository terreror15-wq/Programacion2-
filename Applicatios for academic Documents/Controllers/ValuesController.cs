//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Tarea_1.Models;
//using Tarea_1.Data;
//using Tarea_1.DTOs;

//namespace Tarea_1.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EstudianteController : ControllerBase
//    {
        
        //[HttpGet]
        //public ActionResult<IEnumerable<EstudianteDTOs>> GetEstudiante()
        //{
        //    var estuduante = DatesDefault.students.AsReadOnly();
        //    return Ok(estuduante.Select(x => new EstudianteDTOs
        //    {
        //        Name = x.Name,
        //        Lastname = x.Lastname,
        //        Age = x.Age,
        //        Grade = x.Grade
        //    }));
        //}

//        [HttpPost]

//        public ActionResult AddStudent(EstudianteDTOs student) 
//        {
//            if(student is null) 
//            {
//                return NotFound();

//            }
//            student.Id = DatesDefault.contador++;
//            var Sstudent = new Estudiante
//            {
//                Id = student.Id,
//                Name = student.Name,
//                Lastname = student.Lastname,
//                Age = student.Age,
//                Grade = student.Grade
//            };
//            DatesDefault.students.Add(Sstudent);
//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//         public ActionResult DeleteStudent(int id) 
//        {
//            var studenf = DatesDefault.students.Find(x => x.Id == id);
            
//            if(studenf is null)
//            {
//                return NotFound();
//            }
//            DatesDefault.students.Remove(studenf);
//            return NoContent();

//        }

//        [HttpGet("{id}")]
//        public ActionResult GetStudent(int id)
//        {
//            var oneStudent = DatesDefault.students.Find(x => x.Id == id);
//            if(oneStudent is null)
//            {
//                Console.WriteLine("Student not found");
//                return NotFound();
//            }
//            return Ok(oneStudent);
//        }

//        [HttpPut("{id}")]
//        public ActionResult UpdateStudent(int id, EstudianteDTOs newStudent)
//        {
//            var Nstudent = DatesDefault.students.Find(x => x.Id == id);

//            if(Nstudent is null)
//            {
//                return NotFound();
//            }
           
//            Nstudent.Name = newStudent.Name == null ? Nstudent.Name : newStudent.Name;
//            Nstudent.Lastname = newStudent.Lastname == null ? Nstudent.Lastname : newStudent.Lastname;
//            Nstudent.Age = newStudent.Age == null ? Nstudent.Age : newStudent.Age;
           
//            return Ok(newStudent);
//        }
//    }
//}
