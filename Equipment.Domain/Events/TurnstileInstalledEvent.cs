using Sentinal.Core.Domain.Interfaces;

namespace Equipment.Domain.Events
{
    public class TurnstileInstalledEvent : IDomainEvent
    {
        public int TurnstileId { get; set; }
        public DateTime InstallDate { get; set; }
        public int StationId { get; set; }
        public string? DomainData { get; set; }

        public static TurnstileInstalledEvent Create(int turnstileId, int stationId, DateTime installDate)
        {
            return new TurnstileInstalledEvent()
            {
                TurnstileId = turnstileId,
                StationId = stationId,
                InstallDate = installDate,
            };
        }
    }
}
