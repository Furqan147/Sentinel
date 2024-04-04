using Schedule.Domain.Interfaces;
using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.Events
{
    public class CameraMaintenanceScheduleChangedEvent : IDomainEvent, ICameraMaintenanceScheduleInfo
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CameraId => throw new NotImplementedException();
        public int MaintenanceScheduleId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CronExpression { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
