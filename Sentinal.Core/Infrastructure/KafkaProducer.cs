using CloudNative.CloudEvents;
using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Sentinal.Core.Infrastructure.Interfaces;

namespace Sentinal.Core.Infrastructure
{
    public class KafkaProducer : BackgroundService, IEventWriterProvider
    {

        #region Properties

        public string TopicName { get; private set; }
        private readonly ILogger _logger;
        private readonly ProducerConfig _config;
        private string _message = "";
        private readonly CancellationTokenSource cts = new CancellationTokenSource();

        #endregion

        #region Constructor

        public KafkaProducer(string topic, ProducerConfig config, ILogger logger)
        {
            TopicName = topic;
            _logger = logger;
            _config = config;
        }

        #endregion

        #region Overriden Methods

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await StartAsync(stoppingToken);
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            using (var p = new ProducerBuilder<Null, string>(_config).Build())
            {
                var m = new Message<Null, string>();
                m.Value = _message;
                await p.ProduceAsync(TopicName, m, cancellationToken);
            }
        }

        #endregion

        #region Public Methods

        public async Task Send(CloudEvent evt)
        {
            _message = JsonConvert.SerializeObject(evt);
            await ExecuteAsync(cts.Token);
        }

        #endregion

    }
}
