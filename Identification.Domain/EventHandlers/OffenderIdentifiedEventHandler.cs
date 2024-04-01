using Identification.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Identification.Domain.EventHandlers
{
    public class OffenderIdentifiedEventHandler : IDomainEventHandler<OffenderIdentifiedEvent>
    {
        public Task Handle(OffenderIdentifiedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
