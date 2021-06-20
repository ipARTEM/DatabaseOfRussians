using DBOfRussians.Models;
using Microsoft.EntityFrameworkCore;

namespace DBOfRussians.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Citizen> Citizens { get; set; }

    }
}
