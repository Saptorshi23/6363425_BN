using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<string> students = new List<string> { "Alice", "Bob" };

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id < 0 || id >= students.Count)
                return NotFound("Student not found");

            return Ok(students[id]);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] string name)
        {
            students.Add(name);
            return Ok("Student added successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] string name)
        {
            if (id < 0 || id >= students.Count)
                return BadRequest("Invalid student index");

            students[id] = name;
            return Ok("Student updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (id < 0 || id >= students.Count)
                return BadRequest("Invalid student index");

            students.RemoveAt(id);
            return Ok("Student deleted successfully");
        }
    }
}
