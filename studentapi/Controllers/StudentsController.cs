using Microsoft.AspNetCore.Mvc;
using CrudStudentAPI.Models;
using CrudStudentAPI.Data;
using System.Collections.Generic;

namespace CrudStudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = _repository.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]  
        public ActionResult<Student> GetStudentById(int id)
        {
            var student = _repository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> CreateStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            var createdStudent = _repository.AddStudent(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = createdStudent.Id }, createdStudent);
        }   

    }
}  