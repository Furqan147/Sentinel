using Sentinal.Core.Domain.Interfaces;

namespace Equipment.Domain.Events
{
    public class PassengerEgressEvent : IDomainEvent
    {
        public string? DomainData { get; set; }
        public int TurnstileId { get; }
        public DateTime TransactionDate { get; }

        public PassengerEgressEvent(int turnstileId, DateTime tranDate)
        {
            TurnstileId = turnstileId;
            TransactionDate = tranDate;
        }

        public static PassengerEgressEvent Create(int turnstileId)
        {
            return new PassengerEgressEvent(turnstileId, DateTime.Now);
        }

    }
}
