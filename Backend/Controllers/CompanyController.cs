using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class CompannyController : ControllerBase
{
    private readonly AppDbContext _context;

    public CompannyController(AppDbContext context)
    {
        _context = context;
    }

    // Get all Compannies
    [HttpGet]
    public async Task<ActionResult<List<Companny>>> GetCompannies()
    {
        List<Companny> result = await _context.Companny
/*            .Include(c => c.companny2Properties)
*/            .ToListAsync();
        return result;
    }

    // Get a single Companny by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Companny>> GetCompanny(int id)
    {
        var companny = await _context.Companny.FindAsync(id);

        if (companny == null)
        {
            return NotFound();
        }

        return companny;
    }

    // Create a new Companny
    [HttpPost]
    public async Task<ActionResult<Companny>> CreateCompanny(Companny companny)
    {
        _context.Companny.Add(companny);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCompanny), new { id = companny.Id }, companny);
    }

    // Update an existing Companny
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCompanny(int id, Companny companny)
    {
        if (id != companny.Id)
        {
            return BadRequest();
        }

        _context.Entry(companny).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CompannyExists(id))
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

    // Delete a Companny
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCompanny(int id)
    {
        var companny = await _context.Companny.FindAsync(id);
        if (companny == null)
        {
            return NotFound();
        }

        _context.Companny.Remove(companny);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    [HttpGet("{companyId}/properties")]
    public async Task<List<Properties>> GetPropertiesByCompanyIdAsync(int companyId)
    {
        return await _context.Companny2Property
            .Where(c2p => c2p.CompannyId == companyId)
            .Select(c2p => c2p.properties)
            .ToListAsync();
    }
    private bool CompannyExists(int id)
    {
        return _context.Companny.Any(e => e.Id == id);
    }
}
