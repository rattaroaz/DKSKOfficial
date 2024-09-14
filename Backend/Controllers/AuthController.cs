using DocumentFormat.OpenXml.Math;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly AppDbContext _context;

    public AuthController(IConfiguration configuration, AppDbContext context)
    {
        _configuration = configuration;
        _context = context;
    }

    [HttpPost("token")]
    public async Task<IActionResult> GenerateToken([FromForm] string username, [FromForm] string password)
    {
        // Validate user credentials against the database
        var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
        if (user == null || !VerifyPassword(password, user.PasswordHash))
        {
            return Unauthorized();
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Secret"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role) // Include user role in token
            }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        return Ok(new { Token = tokenString });
    }

    private bool VerifyPassword(string password, string storedHash)
    {
        // Implement your password hashing and verification logic here
        // For example, use a password hashing library to compare the hashed passwords
        return BCrypt.Net.BCrypt.Verify(password, storedHash);
    }
    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword([FromBody] PasswordResetRequest model)
    {
        // Extract username from the JWT token
        var username = User.Identity.Name;

        // Find the user based on the username extracted from the token
        var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);

        if (user == null || !BCrypt.Net.BCrypt.Verify(model.CurrentPassword, user.PasswordHash))
        {
            return BadRequest("Invalid credentials.");
        }

        // Hash the new password and save
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.NewPassword);
        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return Ok("Password reset successfully.");
    }
    public class PasswordResetRequest
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }

}
