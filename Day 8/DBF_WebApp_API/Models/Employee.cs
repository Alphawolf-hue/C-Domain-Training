using System;
using System.Collections.Generic;

namespace DBF_WebApp_API.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public decimal Salary { get; set; }
        public int? DeptId { get; set; }

        public virtual Department? Dept { get; set; }
    }
}
