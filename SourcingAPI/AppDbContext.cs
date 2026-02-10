using Microsoft.EntityFrameworkCore;
using SourcingAPI.Models;

namespace SourcingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SourcingItem> SourcingItems { get; set; }

        public DbSet<MasterRole> MasterRoles { get; set; }
    }
}