using Sentinal.Core.Domain.Interfaces;

namespace Notification.Domain.Events
{
    public class NotificationConfigurationChangedEvent : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
