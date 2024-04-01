using Equipment.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Equipment.Infrastructure.Repositories
{
    public class EquipmentRepository
    {
        EquipmentDbContext _context;
        private IServiceScopeFactory _serviceScopeFactory;

        public EquipmentRepository(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
            IServiceScope scope = _serviceScopeFactory.CreateScope();
            _context = scope.ServiceProvider.GetRequiredService<EquipmentDbContext>();
        }
    }

    internal class EquipmentDbContext : DbContext
    {
        public List<Camera> Cameras { get; set; } = new List<Camera>();
        public List<Turnstile> Turnstiles { get; set; } = new List<Turnstile>();
    }

}
