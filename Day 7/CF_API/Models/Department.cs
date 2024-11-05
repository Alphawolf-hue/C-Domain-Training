using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF_API.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        [Key]
        [DisplayName("Department Id")]
        public int Id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }
        [DisplayName("Department Head")]
        public string DepartmentHead { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
