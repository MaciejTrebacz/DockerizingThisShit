using DockerizingThisShit.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerizingThisShit.Data
{
    public class ApiDbContext :DbContext 
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {

        }

        public DbSet<Driver> Drivers { get; set; }
    }
}
