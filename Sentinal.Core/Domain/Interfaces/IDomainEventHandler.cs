using MediatR;

namespace Sentinal.Core.Domain.Interfaces
{
    public interface IDomainEventHandler<T> : INotificationHandler<T> where T : INotification
    {
    }
}
