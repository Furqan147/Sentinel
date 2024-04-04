using Schedule.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.EventHandlers
{
    public class CameraMaintenanceScheduleChangedEventHandler : IDomainEventHandler<CameraMaintenanceScheduleChangedEvent>
    {
        public Task Handle(CameraMaintenanceScheduleChangedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
