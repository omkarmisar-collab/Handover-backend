using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SourcingAPI.Models; // Change this to your actual Namespace
using SourcingAPI.Data;   // Change this to your actual Namespace

namespace SourcingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SourcingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SourcingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Sourcing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SourcingItem>>> GetItems()
        {
            return await _context.SourcingItems.ToListAsync();
        }

        // POST: api/Sourcing
        [HttpPost]
        public async Task<ActionResult<SourcingItem>> AddItem(SourcingItem item)
        {
            _context.SourcingItems.Add(item);
            await _context.SaveChangesAsync();
            return Ok(item);
        }
    }
}