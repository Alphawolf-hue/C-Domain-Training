using DBF_WebApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DBF_WebApp_API.Repositories
{
    public class DepartmentService : IDepartmentService
    {
        private readonly EmpmanagementSystemContext _context;

        public DepartmentService(EmpmanagementSystemContext context)
        {
            _context = context;
        }

        public List<Department> GetAllDepartments()
        {
            var departments = _context.Departments.ToList();
            return departments.Count > 0 ? departments : null;
        }

        public Department GetDepartmentById(int departmentId)
        {
            if (departmentId != 0)
            {
                var department = _context.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
                return department ?? null;
            }
            return null;
        }

        public int AddNewDepartment(Department department)
        {
            try
            {
                if (department != null)
                {
                    _context.Departments.Add(department);
                    _context.SaveChanges();
                    return department.DepartmentId;
                }
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string UpdateDepartment(Department department)
        {
            var existingDepartment = _context.Departments.FirstOrDefault(x => x.DepartmentId == department.DepartmentId);
            if (existingDepartment != null)
            {
                existingDepartment.DepartmentName = department.DepartmentName;

                _context.Entry(existingDepartment).State = EntityState.Modified;
                _context.SaveChanges();
                return "Department updated successfully.";
            }
            return "Department not found for update.";
        }

        public string DeleteDepartment(int departmentId)
        {
            if (departmentId != 0)
            {
                var department = _context.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
                if (department != null)
                {
                    _context.Departments.Remove(department);
                    _context.SaveChanges();
                    return $"The given department with ID {departmentId} has been removed.";
                }
                return "Department not found for deletion.";
            }
            return "ID should not be null or zero.";
        }
    }
}
