using CloudNative.CloudEvents;

namespace Sentinal.Core.Infrastructure.Interfaces
{
    public interface IEventWriterProvider
    {
        string TopicName { get; }
        Task Send(CloudEvent evt);
    }
}
