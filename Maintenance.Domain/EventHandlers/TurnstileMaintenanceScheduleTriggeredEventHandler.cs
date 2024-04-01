using Maintenance.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.EventHandlers
{
    public class TurnstileMaintenanceScheduleTriggeredEventHandler : IDomainEventHandler<TurnstileMaintenanceScheduleTriggeredEvent>
    {
        public Task Handle(TurnstileMaintenanceScheduleTriggeredEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
