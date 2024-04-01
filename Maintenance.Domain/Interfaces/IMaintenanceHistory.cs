using Maintenance.Domain.Entities;

namespace Maintenance.Domain.Interfaces
{
    public interface IMaintenanceHistory
    {
        IList<WorkOrder>? MaintenanceHistory { get; set; }
    }
}
