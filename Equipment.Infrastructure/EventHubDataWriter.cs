using Azure.Messaging.EventHubs.Producer;
using CloudNative.CloudEvents;
using Sentinal.Core.Infrastructure.Interfaces;

namespace Equipment.Infrastructure
{
    public class EventHubDataWriter : IEventWriterProvider
    {

        #region Properties

        EventHubProducerClient _client = default!;
        public string TopicName { get; private set; } 

        #endregion

        #region Constructor

        public EventHubDataWriter()
        {
            TopicName = "default";
        }

        public EventHubDataWriter(string hubConnectionString) : this()
        {
            _client = new EventHubProducerClient(hubConnectionString);
        } 

        #endregion

        #region Public Methods

        public Task Send(CloudEvent evt)
        {
            return Task.Run(() =>
            {
                _client.SendAsync(new[] { new Azure.Messaging.EventHubs.EventData() { MessageId = evt.Id, EventBody = new BinaryData(evt.Data) } });
            });
        } 

        #endregion

    }
}
