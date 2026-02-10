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

        // PUT: api/Sourcing/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, SourcingItem item)
        {
            // 1️⃣ Check id mismatch
            if (id != item.Id)
            {
                return BadRequest("ID mismatch");
            }

            // 2️⃣ Find existing record
            var existingItem = await _context.SourcingItems.FindAsync(id);

            if (existingItem == null)
            {
                return NotFound("Item not found");
            }

            // 3️⃣ Update fields
            existingItem.SapCode = item.SapCode;
            existingItem.Description = item.Description;
            existingItem.DrawingRevision = item.DrawingRevision;
            existingItem.Commodity = item.Commodity;
            existingItem.Supplier = item.Supplier;
            existingItem.BuyerCST = item.BuyerCST;
            existingItem.ApplicationProduct = item.ApplicationProduct;

            existingItem.CustomerCode = item.CustomerCode;
            existingItem.CostingSheet = item.CostingSheet;
            existingItem.ToolCostStatus = item.ToolCostStatus;
            existingItem.DualSource = item.DualSource;
            existingItem.SaReleasedNumber = item.SaReleasedNumber;
            existingItem.Remarks = item.Remarks;

            existingItem.IsirDocuments = item.IsirDocuments;
            existingItem.PpapDocument = item.PpapDocument;

            // 4️⃣ Save changes
            await _context.SaveChangesAsync();

            return Ok(existingItem);
        }
    }
}