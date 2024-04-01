using MediatR;
using Sentinal.Core.Domain.Interfaces;

namespace Equipment.Domain.Events
{
    public class CameraCreatedEvent : IDomainEvent, INotification
    {
        public string? DomainData { get; set; }
        public int CameraId { get; }
        public DateTime CreatedDate { get; }

        public CameraCreatedEvent(int cameraId, DateTime createdDate)
        {
            CreatedDate = createdDate;
            CameraId = cameraId;
        }
    }
}
