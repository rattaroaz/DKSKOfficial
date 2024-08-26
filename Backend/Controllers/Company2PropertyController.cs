using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class Companny2PropertyController : ControllerBase
{
    private readonly AppDbContext _context;

    public Companny2PropertyController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{companyId}/properties")]
    public async Task<IActionResult> GetPropertiesByCompanyId(int companyId)
    {
        try
        {
            var properties = await _context.Companny2Property
                .Where(c2p => c2p.CompannyId == companyId)
                .Select(c2p => c2p.properties)
                .ToListAsync();

            if (properties == null || !properties.Any())
            {
                return NotFound();
            }

            return Ok(properties);
        }
        catch (Exception ex)
        {
            // Log the exception (if using a logging framework)
            return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
        }
    }
    // Get all relationships between Companny and Properties
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Companny2Property>>> GetCompanny2Properties()
    {
        return await _context.Companny2Property
            .Include(c2p => c2p.companny)
            .Include(c2p => c2p.properties)
            .ToListAsync();
    }

    // Get a specific Companny2Property relationship
    [HttpGet("{compannyId}/{propertyId}")]
    public async Task<ActionResult<Companny2Property>> GetCompanny2Property(int compannyId, int propertyId)
    {
        var companny2Property = await _context.Companny2Property
            .Where(c2p => c2p.CompannyId == compannyId && c2p.PropertiesId == propertyId)
            .Include(c2p => c2p.companny)
            .Include(c2p => c2p.properties)
            .FirstOrDefaultAsync();

        if (companny2Property == null)
        {
            return NotFound();
        }

        return companny2Property;
    }

    // Create a new relationship
    [HttpPost]
    public async Task<ActionResult<Companny2Property>> CreateCompanny2Property(Companny2Property companny2Property)
    {
        _context.Companny2Property.Add(companny2Property);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCompanny2Property), new { compannyId = companny2Property.CompannyId, propertyId = companny2Property.PropertiesId }, companny2Property);
    }

    // Delete a relationship
    [HttpDelete("{compannyId}/{propertyId}")]
    public async Task<IActionResult> DeleteCompanny2Property(int compannyId, int propertyId)
    {
        var companny2Property = await _context.Companny2Property
            .Where(c2p => c2p.CompannyId == compannyId && c2p.PropertiesId == propertyId)
            .FirstOrDefaultAsync();

        if (companny2Property == null)
        {
            return NotFound();
        }

        _context.Companny2Property.Remove(companny2Property);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}