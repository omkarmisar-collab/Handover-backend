using Microsoft.AspNetCore.Mvc;
using SourcingAPI.Data;
using SourcingAPI.Models;

namespace SourcingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterRoleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MasterRoleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok(_context.MasterRoles.ToList());
        }

        [HttpPost]
        public IActionResult AddRole(MasterRole role)
        {
            _context.MasterRoles.Add(role);
            _context.SaveChanges();
            return Ok(role);
        }
    }
}
