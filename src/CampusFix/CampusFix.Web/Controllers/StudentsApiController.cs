using CampusFix.Application.Services;
using CampusFix.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CampusFix.Web.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsApiController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentsApiController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var student = _studentService.GetStudentById(id);

            if (student == null)
            {
                return NotFound($"Student with ID '{id}' was not found.");
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            _studentService.SaveStudent(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Student student)
        {
            if (id != student.Id)
            {
                return BadRequest("Route ID does not match student ID.");
            }

            _studentService.SaveStudent(student);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _studentService.DeleteStudent(id);
            return NoContent();
        }
    }
}