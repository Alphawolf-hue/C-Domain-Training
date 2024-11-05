using CF_API.Data;
using CF_API.Models;

namespace CF_API.Repositories
{
    public class EmployeeService : IEmployeeService
    {
        private MyDbContext _context;
        public EmployeeService(MyDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees() 
        {
            var employees = _context.Employees.ToList();
            if (employees.Count > 0) { return employees; }
            else return null;
        }
        public int AddNewEmployee(Employee employee) 
        {
            try
            {
                if (employee != null)
                {
                    _context.Employees.Add(employee);
                    _context.SaveChanges();
                    return employee.EmployeeId;
                }
                else return 0;
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }
        public string DeleteEmployee(int employeeId) 
        {
            if(employeeId!=null)
            {
                var employee= _context.Employees.FirstOrDefault(x => x.EmployeeId==employeeId);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    return $"the Given Employee {employeeId} has been Removed";
                }
                else return "Something went wrong with deletion";
            }
            return "Id should not be null or zero";
        }
        public Employee GetEmployeeById(int employeeId)
        {
            if (employeeId != 0 || employeeId!=null)
            {
                var employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
                if (employee != null) 
                {
                    return employee;
                }
                else
                    return null;
            }
            return null;
        }

        public string UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Designation = employee.Designation;
                existingEmployee.Email = employee.Email;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.DepartmentId = employee.DepartmentId;
                _context.Entry(existingEmployee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return "Employee updated successfully";
            }
            else
            {
                return "Employee not found for update";
            }
        }
    }
}
