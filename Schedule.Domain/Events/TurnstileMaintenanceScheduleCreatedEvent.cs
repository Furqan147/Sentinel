using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.Events
{
    public class TurnstileMaintenanceScheduleCreatedEvent : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
