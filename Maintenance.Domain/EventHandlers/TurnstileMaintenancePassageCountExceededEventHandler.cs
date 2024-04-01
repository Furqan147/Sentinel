using Maintenance.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.EventHandlers
{
    public class TurnstileMaintenancePassageCountExceededEventHandler : IDomainEventHandler<TurnstileMaintenancePassageCountExceededEvent>
    {
        public Task Handle(TurnstileMaintenancePassageCountExceededEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
