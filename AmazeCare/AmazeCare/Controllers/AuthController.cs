using AmazeCare.Services;
using AmazeCare.Dtos;
using AmazeCare.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using IAuthenticationService = AmazeCare.Services.IAuthenticationService;
using Microsoft.IdentityModel.Tokens;
using AuthenticationService = AmazeCare.Services.AuthenticationService;

namespace AmazeCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;

        public AuthController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        { 
            var token = await _authenticationService.AuthenticateUserAsync(login.Username, login.Password); 
            if (token == null)
            { return Unauthorized(); } 
            return Ok(new { Token = token });
        }
    }
}
