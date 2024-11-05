﻿using Microsoft.AspNetCore.Mvc;
using WebAppAPI.Models;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        static List<Employee> employees;
        static EmployeesController()
        {
            employees = new List<Employee>()
            {
                new Employee() {EmployeeId = 1, Name = "Aniket",DOJ=new DateTime(2024,10,22),Designation="Trainee",Salary=34354.32M},
                new Employee() {EmployeeId = 2, Name = "Pedri",DOJ=new DateTime(2024,10,22),Designation="Trainee",Salary=34654.32M},
                new Employee() {EmployeeId = 3, Name = "Robert",DOJ=new DateTime(2024, 10, 22),Designation="Trainee",Salary=34359.32M},
                new Employee() {EmployeeId = 4, Name = "Raphinha",DOJ=new DateTime(2024, 10,22),Designation="Trainee",Salary=34754.32M},
                new Employee() {EmployeeId = 5, Name = "Casado",DOJ=new DateTime(2024, 10, 22),Designation="Trainee",Salary=34394.32M},
            };
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            if(employees.Count>0)
                return Ok(employees);
            else 
                return NotFound();
        }

        [HttpPost]
        public IActionResult PostEmployee([FromBody] Employee employee)
        {
            if (employee == null) return BadRequest();
            else 
                employees.Add(employee);
            return CreatedAtAction(nameof(GetAllEmployees), new { id=employee.EmployeeId,message="data Added"} );
        }

        [HttpPut]
        public IActionResult PutEmployee(int id,Employee employee)
        {
            if(id!=employee.EmployeeId)
            {
                return BadRequest("Id Mismatch");
            }
            var existingEmployee = employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            if(existingEmployee==null)
            {
                return NotFound();
            }
            existingEmployee.Name = employee.Name;
            existingEmployee.DOJ = employee.DOJ;
            existingEmployee.Designation = employee.Designation;
            existingEmployee.Salary = employee.Salary;
            return Ok(existingEmployee);
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            if (existingEmployee == null) return NotFound();
            employees.Remove(existingEmployee);
            return Ok(existingEmployee.EmployeeId + " Removed");
        }
    }
}