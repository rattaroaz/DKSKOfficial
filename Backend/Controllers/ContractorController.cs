using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class ContractorController : ControllerBase
{
    private readonly AppDbContext _context;

    public ContractorController(AppDbContext context)
    {
        _context = context;
    }

    // Get all Contractor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contractor>>> GetContractors()
    {
        return await _context.Contractor.ToListAsync();
    }
    // Get a single Contractor by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Contractor>> GetContractorById(int id)
    {
        var contractor = await _context.Contractor.FirstOrDefaultAsync(c => c.Id == id);

        if (contractor == null)
        {
            return NotFound($"Contractor with Id = {id} not found.");
        }

        return Ok(contractor);
    }

    [HttpPost]
    public async Task<ActionResult> CreateContractor([FromBody] Contractor contractor)
    {
        if (contractor == null)
        {
            return BadRequest("Contractor data is null.");
        }

        try
        {
            // Map DTO to the actual entity
  

            _context.Contractor.Add(contractor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContractorById), new { id = contractor.Id }, contractor);
        }
        catch (Exception ex)
        {
            // Log error
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateContractor(int id, [FromBody] Contractor contractor)
    {
        if (id != contractor.Id)
        {
            return BadRequest();
        }

        _context.Entry(contractor).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }
    // Delete a Contractor
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContractor(int id)
    {
        var contractor = await _context.Contractor.FindAsync(id);
        if (contractor == null)
        {
            return NotFound();
        }

        try
        {
            _context.Contractor.Remove(contractor);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, "An error occurred while deleting the contractor.");
        }

        return NoContent();
    }

    private bool ContractorExists(int id)
    {
        return _context.Contractor.Any(e => e.Id == id);
    }
}
