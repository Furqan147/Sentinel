namespace Sentinal.Core.Infrastructure.Interfaces
{
    public interface IEventReaderProvider
    {
        IEnumerable<string> TopicNames { get; }
        Task Receive();
    }
}
