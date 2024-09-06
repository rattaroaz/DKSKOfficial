using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        try
        {
            var result = await _context.Companny
                .Include(c => c.Supervisors)
                    .ThenInclude(s => s.Properties)
                .ToListAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            // Log the exception (consider using a logging framework)
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, "An error occurred while fetching the companies.");
        }
    }

    // Get a single Companny by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Companny>> GetCompanyById(int id)
    {
        var company = await _context.Companny
            .Include(c => c.Supervisors)
            .ThenInclude(s => s.Properties)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (company == null)
        {
            return NotFound($"Company with Id = {id} not found.");
        }

        return Ok(company);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCompany([FromBody] CompannyDto companyDto)
    {
        if (companyDto == null)
        {
            return BadRequest("Company data is null.");
        }

        try
        {
            // Map DTO to the actual entity
            var company = new Companny
            {
                Name = companyDto.Name,
                Phone = companyDto.Phone,
                Email = companyDto.Email,
                Address = companyDto.Address,
                City = companyDto.City,
                Zip = companyDto.Zip,
                SpecialNote = companyDto.SpecialNote,
                Supervisors = companyDto.Supervisors.Select(s => new Supervisor
                {
                    Name = s.Name,
                    Phone = s.Phone,
                    Email = s.Email,
                    Properties = s.Properties.Select(p => new Properties
                    {
                        Name = p.Name,
                        Address = p.Address,
                        City = p.City,
                        Zip = p.Zip,
                        GateCode = p.GateCode,
                        GarageRemoteCode = p.GarageRemoteCode,
                        ManagerName = p.ManagerName,
                        ManagerPhone = p.ManagerPhone,
                        ManagerEmail = p.ManagerEmail,
                        LockBox = p.LockBox,
                        SpecialNote = p.SpecialNote
                    }).ToList()
                }).ToList()
            };

            _context.Companny.Add(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompanyById), new { id = company.Id }, company);
        }
        catch (Exception ex)
        {
            // Log error
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateCompany(int id, [FromBody] CompannyDto companyDto)
    {
        if (companyDto == null)
        {
            return BadRequest("Company data is null.");
        }

        try
        {
            var existingCompany = await _context.Companny
                .Include(c => c.Supervisors)
                .ThenInclude(s => s.Properties)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (existingCompany == null)
            {
                return NotFound($"Company with Id = {id} not found.");
            }

            // Update existing entity with values from the DTO
            existingCompany.Name = companyDto.Name;
            existingCompany.Phone = companyDto.Phone;
            existingCompany.Email = companyDto.Email;
            existingCompany.Address = companyDto.Address;
            existingCompany.City = companyDto.City;
            existingCompany.Zip = companyDto.Zip;
            existingCompany.SpecialNote = companyDto.SpecialNote;

            // Update supervisors and properties
            existingCompany.Supervisors.Clear();
            foreach (var supervisorDto in companyDto.Supervisors)
            {
                var supervisor = new Supervisor
                {
                    Name = supervisorDto.Name,
                    Phone = supervisorDto.Phone,
                    Email = supervisorDto.Email,
                    Properties = supervisorDto.Properties.Select(p => new Properties
                    {
                        Name = p.Name,
                        Address = p.Address,
                        City = p.City,
                        Zip = p.Zip,
                        GateCode = p.GateCode,
                        GarageRemoteCode = p.GarageRemoteCode,
                        ManagerName = p.ManagerName,
                        ManagerPhone = p.ManagerPhone,
                        ManagerEmail = p.ManagerEmail,
                        LockBox = p.LockBox,
                        SpecialNote = p.SpecialNote
                    }).ToList()
                };

                existingCompany.Supervisors.Add(supervisor);
            }

            _context.Companny.Update(existingCompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            // Log error
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
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

        try
        {
            _context.Companny.Remove(companny);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, "An error occurred while deleting the company.");
        }

        return NoContent();
    }

    private bool CompannyExists(int id)
    {
        return _context.Companny.Any(e => e.Id == id);
    }
}
