using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Training_Auth_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        //[Authorize(Roles = "User")]
        [Authorize(Roles = "Admin")]
        ////[AllowAnonymous]
        [HttpGet]
        public async Task<string> GetSampleData()
        {
            return "Sample Data From Sample Controller";
        }
    }
}
