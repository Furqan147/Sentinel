using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.Events
{
    public class CameraMaintenanceScheduleTriggeredEvent : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
