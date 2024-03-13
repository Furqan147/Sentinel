using Sentinal.Core.Domain.Interfaces;
using Station.Domain.Entities;

namespace Station.Domain.Aggregates
{
    public class Station : IDomainAggregateRoot
    {
        public StationInfo StationData { get; private set; } = default!;
    }
}
