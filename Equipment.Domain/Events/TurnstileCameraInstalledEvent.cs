using Sentinal.Core.Domain.Interfaces;

namespace Equipment.Domain.Events
{
    public class TurnstileCameraInstalledEvent : IDomainEvent
    {
        public int TurnstileId { get; set; }
        public DateTime InstallDate { get; set; }
        public int CameraId { get; set; }

        public string? DomainData { get; set; }

        public TurnstileCameraInstalledEvent(int turnstileId, int cameraId, DateTime installDate)
        {
            TurnstileId = turnstileId;
            CameraId = cameraId;
            InstallDate = installDate;
        }
    }
}
