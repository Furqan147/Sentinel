using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.Aggregates
{
    public class TurnstileMaintenanceSchedule : IDomainAggregateRoot
    {
        public int CameraId { get; set; }
    }
}
