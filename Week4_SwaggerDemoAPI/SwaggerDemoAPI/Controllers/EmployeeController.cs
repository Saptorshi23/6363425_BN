using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")] // Only Admin or POC can access
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Alice",
                Salary = 50000,
                Permanent = true,
                Department = new Department { Id = 1, Name = "IT" },
                Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" } },
                DateOfBirth = new DateTime(1990, 1, 1)
            }
        };

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_employees);
        }
    }
}
