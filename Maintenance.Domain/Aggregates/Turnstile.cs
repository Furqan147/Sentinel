using Maintenance.Domain.Entities;
using Maintenance.Domain.Interfaces;
using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.Aggregates
{
    public class Turnstile : IDomainAggregateRoot, IMaintenanceHistory
    {
        public int TurnstileId { get; set; }
        public IList<WorkOrder>? MaintenanceHistory { get; set; }

        public Turnstile()
        {
            MaintenanceHistory = new List<WorkOrder>();
        }
    }
}
