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
        // GET api/invoice/filter?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd
        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoicesByDateRange(DateTime startDate, DateTime endDate)
        {
            var filteredInvoices = await _context.Invoice
                .Where(i => i.StartDate >= startDate && i.StartDate <= endDate && i.Status == 0)
                .ToListAsync();

            if (filteredInvoices == null || !filteredInvoices.Any())
            {
                return NotFound("No invoices found within the specified date range.");
            }

            return Ok(filteredInvoices);
        }
        [HttpGet("receivable")]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoicesReceivable()
        {
            var filteredInvoices = await _context.Invoice
                .Where(i => i.Status == 1)
                .ToListAsync();

            if (filteredInvoices == null || !filteredInvoices.Any())
            {
                return NotFound("No invoices found within the specified date range.");
            }

            return Ok(filteredInvoices);
        }
        [HttpGet("active")]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoicesActive()
        {
            var filteredInvoices = await _context.Invoice
                .Where(i => i.Status == 0)
                .ToListAsync();

            if (filteredInvoices == null || !filteredInvoices.Any())
            {
                return NotFound("No invoices found within the specified date range.");
            }

            return Ok(filteredInvoices);
        }
        [HttpGet("sales")]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoicesSales()
        {
            var filteredInvoices = await _context.Invoice
                .Where(i => i.Status != 0)
                .ToListAsync();

            if (filteredInvoices == null || !filteredInvoices.Any())
            {
                return NotFound("No invoices found within the specified date range.");
            }

            return Ok(filteredInvoices);
        }
        // PUT api/invoice/update
        [HttpPut("update")]
        public async Task<IActionResult> PutItems([FromBody] List<Invoice> invoices)
        {
            if (invoices == null || !invoices.Any())
            {
                return BadRequest("No invoices to update.");
            }

            foreach (var invoice in invoices)
            {
                var existingInvoice = await _context.Invoice.FindAsync(invoice.Id);
                if (existingInvoice == null)
                {
                    return NotFound($"Invoice with ID {invoice.Id} not found.");
                }

                // Update the existing invoice with the new values
                _context.Entry(existingInvoice).CurrentValues.SetValues(invoice);
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
