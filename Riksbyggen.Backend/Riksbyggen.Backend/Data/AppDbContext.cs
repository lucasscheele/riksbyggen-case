using Microsoft.EntityFrameworkCore;
using Riksbyggen.Backend.Models;

namespace Riksbyggen.Backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Company> Companies { get; set; } = null!;
    }
}
