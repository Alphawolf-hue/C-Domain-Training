using DBF_WebApp_API.Models;
using DBF_WebApp_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBF_WebApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        // GET: api/departments
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var departments = _departmentService.GetAllDepartments();
            if (departments == null || departments.Count == 0)
            {
                return NotFound("No departments found.");
            }
            return Ok(departments);
        }

        // GET: api/departments/5
        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound($"Department with ID {id} not found.");
            }
            return Ok(department);
        }

        // POST: api/departments
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            if (department == null)
            {
                return BadRequest("Invalid department data.");
            }

            int departmentId = _departmentService.AddNewDepartment(department);
            if (departmentId == 0)
            {
                return BadRequest("Failed to add department.");
            }

            return CreatedAtAction(nameof(GetDepartmentById), new { id = departmentId }, department);
        }

        // PUT: api/departments/5
        [HttpPut("{id}")]
        public IActionResult UpdateDepartment(int id, Department department)
        {
            if (id != department.DepartmentId)
            {
                return BadRequest("Department ID mismatch.");
            }

            string result = _departmentService.UpdateDepartment(department);
            if (result == "Department not found for update.")
            {
                return NotFound($"Department with ID {id} not found.");
            }
            return Ok(result);
        }

        // DELETE: api/departments/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            string result = _departmentService.DeleteDepartment(id);
            if (result.Contains("not found"))
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
