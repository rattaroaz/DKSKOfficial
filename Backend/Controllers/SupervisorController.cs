using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class SupervisorController : ControllerBase
{
    private readonly AppDbContext _context;

    public SupervisorController(AppDbContext context)
    {
        _context = context;
    }

    // Get all Contractor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Supervisor>>> GetManagers()
    {
        return await _context.Supervisor.ToListAsync();
    }

}
