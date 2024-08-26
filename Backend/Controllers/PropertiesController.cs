using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
[Route("api/[controller]")]
[ApiController]
public class PropertiesController : ControllerBase
{
    private readonly AppDbContext _context;

    public PropertiesController(AppDbContext context)
    {
        _context = context;
    }

    // Get all Properties
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Properties>>> GetProperties()
    {
        return await _context.Properties.ToListAsync();
    }

    // Get a single Property by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Properties>> GetProperty(int id)
    {
        var property = await _context.Properties.FindAsync(id);

        if (property == null)
        {
            return NotFound();
        }

        return property;
    }

    // Create a new Property
    [HttpPost]
    public async Task<ActionResult<Properties>> CreateProperty(Properties property)
    {
        _context.Properties.Add(property);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProperty), new { id = property.Id }, property);
    }

    // Update an existing Property
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProperty(int id, Properties property)
    {
        if (id != property.Id)
        {
            return BadRequest();
        }

        _context.Entry(property).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PropertyExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // Delete a Property
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProperty(int id)
    {
        var property = await _context.Properties.FindAsync(id);
        if (property == null)
        {
            return NotFound();
        }

        _context.Properties.Remove(property);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PropertyExists(int id)
    {
        return _context.Properties.Any(e => e.Id == id);
    }
}