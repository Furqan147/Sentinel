using Confluent.Kafka;
using Identification.Domain.EventHandlers;
using Identification.Domain.Events;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sentinal.Core;
using Sentinal.Core.Domain.Interfaces;

class Program
{
    static ConsumerConfig _config = new ConsumerConfig();
    static IEnumerable<string> topicNames = new List<string>();

    static async Task Main(string[] args)
    {
        using IHost host = CreateHostBuilder(args).Build();
        await host.RunAsync();
    }


    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((hostingContext, configuration) =>
        {
            configuration.Sources.Clear();
            IHostEnvironment env = hostingContext.HostingEnvironment;
            configuration
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
            IConfigurationRoot config = configuration.Build();
            _config = new ConsumerConfig() { BootstrapServers = config.GetValue<string>("KafkaServer"), GroupId = config.GetValue<string>("DefaultGroupId") };
            topicNames = config.GetValue<IEnumerable<string>>("Topics");

        })
        .ConfigureServices((_, services) =>
            services.AddHostedService<KafkaConsumer>((s) => { return new KafkaConsumer(string.Empty); })
        .AddScoped<IDomainEventHandler<PassengerIdentifiedEvent>>((s) => { return new PassengerIdentifiedEventHandler(); })
        .AddTransient<IDomainEventHandler<OffenderIdentifiedEvent>>((s) => { return new OffenderIdentifiedEventHandler(); }));
}