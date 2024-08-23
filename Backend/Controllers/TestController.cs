using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DKSKOfficial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TestController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/yourcontroller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Companny>>> GetItems()
        {
            return await _context.Companny.ToListAsync();
        }

        // GET api/yourcontroller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Companny>> GetItem(int id)
        {
            var item = await _context.Companny.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // POST api/yourcontroller
        [HttpPost]
        public async Task<ActionResult<Companny>> PostItem(Companny model)
        {
            _context.Companny.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItem), new { id = model.Id }, model);
        }

        // PUT api/yourcontroller/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Companny model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/yourcontroller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Companny.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Companny.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
