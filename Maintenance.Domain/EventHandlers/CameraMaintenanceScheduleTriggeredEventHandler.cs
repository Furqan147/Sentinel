using Maintenance.Domain.Events;
using Sentinal.Core.Domain.Interfaces;

namespace Maintenance.Domain.EventHandlers
{
    public class CameraMaintenanceScheduleTriggeredEventHandler : IDomainEventHandler<CameraMaintenanceScheduleTriggeredEvent>
    {
        public Task Handle(CameraMaintenanceScheduleTriggeredEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
