using Maintenance.Domain.Entities;
using Maintenance.Domain.Interfaces;
using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.Aggregates
{
    public class Camera : IDomainAggregateRoot, IMaintenanceHistory
    {
        public int CameraId { get; set; }
        public IList<WorkOrder>? MaintenanceHistory { get; set; }
    }
}
