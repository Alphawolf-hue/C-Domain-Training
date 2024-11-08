using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendance.Models;

namespace StudentAttendance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsAtendanceController : ControllerBase
    {
        static List<StuAttendance> attendanceList;
        [HttpGet]
        public List<StuAttendance> Get()
        {
            attendanceList = new List<StuAttendance> {
               new StuAttendance() { StudentID=101,StudentName="Aniket", AttendancePercentage=90},
                new StuAttendance() { StudentID=102,StudentName="Inigo", AttendancePercentage=91},
                new StuAttendance() { StudentID=103,StudentName="Robert", AttendancePercentage=92},
                new StuAttendance() { StudentID=104,StudentName="Nigar", AttendancePercentage=93},

          };
            return attendanceList;
        }
    }
}
