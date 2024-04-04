using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.Aggregates
{
    public class CameraMaintenanceSchedule : IDomainAggregateRoot
    {
        public int CameraId { get; set; }
    }
}
