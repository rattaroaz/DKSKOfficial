using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DKSKOfficial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly AppDbContext _context;
        public InvoiceController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/invoicecontoller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetItems()
        {
            return await _context.Invoice.ToListAsync();
        }

        // GET api/invoicecontoller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invoice>> GetItem(int id)
        {
            var item = await _context.Invoice.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // POST api/invoicecontoller
        [HttpPost]
        public async Task<ActionResult<Invoice>> PostItem(Invoice model)
        {
            _context.Invoice.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItem), new { id = model.Id }, model);
        }

        // PUT api/invoicecontoller/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Invoice model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/invoicecontoller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Invoice.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Invoice.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
