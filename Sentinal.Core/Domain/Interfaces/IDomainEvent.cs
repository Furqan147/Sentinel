using MediatR;

namespace Sentinal.Core.Domain.Interfaces
{
    public interface IDomainEvent : INotification
    {
        public string? DomainData { get; set; }
    }
}
