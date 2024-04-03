using Sentinal.Core.Domain.Interfaces;

namespace Notification.Domain.Entities
{
    public class NotificationConfiguration : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
