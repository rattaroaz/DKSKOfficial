using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class ManagerController : ControllerBase
{
    private readonly AppDbContext _context;

    public ManagerController(AppDbContext context)
    {
        _context = context;
    }

    // Get all Contractor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Manager>>> GetManagers()
    {
        return await _context.Manager.ToListAsync();
    }

}
