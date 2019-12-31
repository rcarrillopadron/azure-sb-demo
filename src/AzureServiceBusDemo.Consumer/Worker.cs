using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.EventHubs;
using Microsoft.Azure.EventHubs.Processor;
using AzureServiceBusDemo.Shared;
using Microsoft.Extensions.Configuration;

namespace AzureServiceBusDemo.Consumer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private EventProcessorHost _eventProcessorHost;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Registering EventProcessor...");

            IConfiguration configuration = new ConfigurationBuilder().AddUserSecrets<Worker>().Build();
            var config = new TheConfig(configuration);
            
            _eventProcessorHost = new EventProcessorHost(
                config.EventHubName,
                PartitionReceiver.DefaultConsumerGroupName,
                config.EventHubConnectionString,
                config.StorageConnectionString,
                config.StorageContainerName);

            // Registers the Event Processor Host and starts receiving messages
            _eventProcessorHost.RegisterEventProcessorAsync<SimpleEventProcessor>();
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Receiving data. Running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _eventProcessorHost.UnregisterEventProcessorAsync();
            return base.StopAsync(cancellationToken);
        }
    }
}
