using Schedule.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Schedule.Domain.EventHandlers
{
    public class CameraMaintenanceScheduleRemovedEventHandler : IDomainEventHandler<CameraMaintenanceScheduleRemovedEvent>
    {
        public Task Handle(CameraMaintenanceScheduleRemovedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
