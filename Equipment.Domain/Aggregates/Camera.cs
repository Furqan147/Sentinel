using Equipment.Domain.ValueObjects;

namespace Equipment.Domain.Aggregates
{
    internal class Camera
    {
        public EquipmentInfo Model { get; private set; }
        public int CameraId { get; private set; }
        public int StationId { get; private set; }
        public int? TurnstileId { get; private set; }
    }
}
