using Microsoft.EntityFrameworkCore;
using Riksbyggen.Backend.Models;

namespace Riksbyggen.Backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Apartment> Apartments { get; set; } = null!;
        public DbSet<Contract> Contracts { get; set; } = null!;
    }
}
