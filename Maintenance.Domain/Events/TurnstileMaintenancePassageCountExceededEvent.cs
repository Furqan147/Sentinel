using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.Events
{
    public class TurnstileMaintenancePassageCountExceededEvent : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
