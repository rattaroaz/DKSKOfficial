using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DKSKOfficial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobDescriptionController : ControllerBase
    {
        private readonly AppDbContext _context;
        public JobDescriptionController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/jobdescriptioncontroller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobDiscription>>> GetItems()
        {
            return await _context.JobDiscription.ToListAsync();
        }

        // GET api/jobdescriptioncontroller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobDiscription>> GetItem(int id)
        {
            var item = await _context.JobDiscription.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // POST api/jobdescriptioncontroller
        [HttpPost]
        public async Task<ActionResult<JobDiscription>> PostItem(JobDiscription model)
        {
            _context.JobDiscription.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItem), new { id = model.Id }, model);
        }

        // PUT api/jobdescriptioncontroller/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, JobDiscription model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/jobdescriptioncontroller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.JobDiscription.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.JobDiscription.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE and PUT new data - Replace all data
        // POST api/jobdescriptioncontroller/replace
        [HttpPost("replace")]
        public async Task<IActionResult> ReplaceAllItems(List<JobDiscription> newItems)
        {
            // Step 1: Delete all existing data
            var allItems = await _context.JobDiscription.ToListAsync();
            _context.JobDiscription.RemoveRange(allItems);

            // Step 2: Add the new data
            _context.JobDiscription.AddRange(newItems);

            // Step 3: Save the changes
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
