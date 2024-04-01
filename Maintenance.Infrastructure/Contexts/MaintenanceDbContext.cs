using Maintenance.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace Maintenance.Infrastructure.Contexts
{
    internal class MaintenanceDbContext : DbContext
    {
        public DbSet<Camera> Cameras { get; set; } = default!;
        public DbSet<Turnstile> Turnstiles { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
