using Schedule.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.EventHandlers
{
    public class CameraMaintenanceScheduleCreatedEventHandler : IDomainEventHandler<CameraMaintenanceScheduleCreatedEvent>
    {
        public Task Handle(CameraMaintenanceScheduleCreatedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
