using DBF_WebApp_API.Models;

namespace DBF_WebApp_API.Repositories
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int departmentId);
        int AddNewDepartment(Department department);
        string UpdateDepartment(Department department);
        string DeleteDepartment(int departmentId);
    }
}
