using Identification.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Identification.Domain.EventHandlers
{
    public class PassengerIdentifiedEventHandler : IDomainEventHandler<PassengerIdentifiedEvent>
    {
        public Task Handle(PassengerIdentifiedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
