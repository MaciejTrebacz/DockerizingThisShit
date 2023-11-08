using DockerizingThisShit.Data;
using DockerizingThisShit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DockerizingThisShit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public DriverController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet("AddAndGet")]
        public async Task<IActionResult> Get()
        {
            var driver = new Driver()
            {
                DriverNumber = 133,
                Name = "Sirrr"
            };
            _context.Add(driver);
            await _context.SaveChangesAsync();
            var allDrivers = await _context.Drivers.ToListAsync();
            return Ok(allDrivers);
        }

    }
}
