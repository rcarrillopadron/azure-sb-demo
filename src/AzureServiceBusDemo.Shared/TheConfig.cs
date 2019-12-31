using Microsoft.Extensions.Configuration;

namespace AzureServiceBusDemo.Shared
{
    public class TheConfig
    {
        private readonly IConfiguration _configuration;

        public TheConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string EventHubConnectionString => _configuration["EventHubConnectionString"];
        public string EventHubName => _configuration["EventHubName"];
        public string StorageContainerName => _configuration["StorageContainerName"];
        public string StorageAccountName => _configuration["StorageAccountName"];
        public string StorageAccountKey => _configuration["StorageAccountKey"];

        public string StorageConnectionString =>
            $"DefaultEndpointsProtocol=https;AccountName={StorageAccountName};AccountKey={StorageAccountKey}";
    }
}
