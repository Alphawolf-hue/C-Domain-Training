using AmazeCare.Dtos;
using AmazeCare.Models;
using AmazeCare.Services;
using AmazeCare.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AmazeCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // Register User
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            if (registerModel == null)
            {
                return BadRequest("Invalid data.");
            }
            if (registerModel.Password != registerModel.ConfirmPassword)
            {
                return BadRequest("Passwords do not match.");
            }
            // Map RegisterModel to User
            var user = new User
            {
                Username = registerModel.Username,
              
                PasswordHash = registerModel.Password, 
                
                RoleId=registerModel.RoleId,
            };

            var result = await _userService.RegisterAsync(user);

            if (result == null)
            {
                return BadRequest("User registration failed.");
            }

            return Ok("User registered successfully.");
        }

        // Login User
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (loginModel == null)
            {
                return BadRequest("Invalid data.");
            }

            var user = await _userService.LoginAsync(loginModel.Username, loginModel.Password);
            if (user == null)
            {
                return Unauthorized("Invalid credentials.");
            }

            return Ok("Login successful.");
        }
    }
}
