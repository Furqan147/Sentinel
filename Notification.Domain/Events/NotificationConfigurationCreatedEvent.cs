using Sentinal.Core.Domain.Interfaces;

namespace Notification.Domain.Events
{
    internal class NotificationConfigurationCreatedEvent : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
