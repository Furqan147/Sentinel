using Sentinal.Core.Domain.Interfaces;

namespace Identification.Domain.Events
{
    public class OffenderIdentifiedEvent : IDomainEvent
    {
        public string? DomainData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
