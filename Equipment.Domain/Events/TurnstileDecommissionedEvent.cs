using Sentinal.Core.Domain.Interfaces;

namespace Equipment.Domain.Events
{
    public class TurnstileDecommissionedEvent : IDomainEvent
    {
        public string? DomainData { get; set; }
        public int TurnstileId { get; set; }
        public DateTime DecommissionDate { get; set; }

        public TurnstileDecommissionedEvent(int turnstileId, DateTime decomDate)
        {
            TurnstileId = turnstileId;
            DecommissionDate = decomDate;
        }
    }
}
