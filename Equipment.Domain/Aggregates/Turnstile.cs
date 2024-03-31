using Equipment.Domain.ValueObjects;

namespace Equipment.Domain.Aggregates
{
    public class Turnstile
    {
        public EquipmentInfo Model { get; private set; }
        public int TurnstileId { get; private set; }
        public int StationId { get; private set; }
        public DateTime? DateInstalled { get; private set; }
        public DateTime? DateDecommissioned { get; private set; }

        public Turnstile(EquipmentInfo info, int turnstileId, int stationId, DateTime? installDate, DateTime? decommDate)
        {

            Model = info;
            TurnstileId = turnstileId;
            StationId = stationId;
            DateInstalled = installDate;
            DateDecommissioned = decommDate;

        }
    }
}
