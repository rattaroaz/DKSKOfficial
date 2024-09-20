using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DKSKOfficial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCompanyInfoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MyCompanyInfoController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/yourcontroller
        [HttpGet]
        public async Task<ActionResult<MyCompanyInfo>> GetItems()
        {
            var item = await _context.MyCompanyInfo.FindAsync(1);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

 

        // PUT api/yourcontroller
        public async Task<IActionResult> PutItem(MyCompanyInfo model)
        {
            model.Id = 1;
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
