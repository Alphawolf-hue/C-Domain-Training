using AmazeCare.Data;
using AmazeCare.Dtos;
using AmazeCare.Models;
using AmazeCare.Repositories;
using AmazeCare.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AmazeCare.Services
{
    public class AuthenticationService
    {
        private readonly AmazeCareDbContext _context; 
        private readonly IConfiguration _configuration;
        public AuthenticationService(AmazeCareDbContext context, IConfiguration configuration)
        {
            _context = context; 
            _configuration = configuration;
        }
        public async Task<string> AuthenticateUserAsync(string username, string password) 
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username); 
            if (user == null || !VerifyPassword(password, user.PasswordHash)) 
            { return null; }
            return GenerateJwtToken(user);
        }
        private bool VerifyPassword(string password, string storedHash) 
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash); 
        }
        private string GenerateJwtToken(User user) 
        {
            var claims = new[] 
            { 
                new Claim(JwtRegisteredClaimNames.Sub, user.UserID.ToString()),
                new Claim(ClaimTypes.Name, user.Username)
            }; 
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256); 

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"], 
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1), 
                signingCredentials: creds); 
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
